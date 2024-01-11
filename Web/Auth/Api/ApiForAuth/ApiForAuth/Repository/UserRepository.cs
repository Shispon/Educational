using ApiForAuth.Domain;
using ApiForAuth.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiForAuth.Repository
{
    public interface IUserRepository
    {
        UserResponse InsertUser(UserModel user);
        UserResponse AuthenticateUser(UserAuth user);
    }

    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;
        private readonly string _jwtSecret; // Секретный ключ для подписи токена

        public UserRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _jwtSecret = configuration.GetValue<string>("JwtSecret");
        }

        public UserResponse InsertUser(UserModel userModel)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand(
                        "SELECT auth.insert__user(@login, @password, @first_name, @middle_name, @last_name, @mail, @number_phone)",
                        connection
                    ))
                    {
                        command.Parameters.AddWithValue("@login", userModel.Login);
                        command.Parameters.AddWithValue("@password", userModel.Password);
                        command.Parameters.AddWithValue("@first_name", userModel.FirstName);
                        command.Parameters.AddWithValue("@middle_name", userModel.MiddleName);
                        command.Parameters.AddWithValue("@last_name", userModel.LastName);
                        command.Parameters.AddWithValue("@mail", userModel.Mail);
                        command.Parameters.AddWithValue("@number_phone", userModel.NumberPhone);

                        var newUserId = (int)command.ExecuteScalar();

                        var userData = new UserData
                        {
                            Id = newUserId,
                            Name = $"{userModel.FirstName} {userModel.MiddleName} {userModel.LastName}",
                            Email = userModel.Mail,
                            Token = GenerateJwtToken(newUserId)
                        };
                       
                        return UserResponse.Success("Success", userData);
                    }
                }
            }
            catch (Npgsql.PostgresException ex) when (ex.SqlState == "23505")
            {
                // Если возникла ошибка с повторяющимся ключом, выводим нужное сообщение
                return UserResponse.Error("Такой пользователь уже зарегистрирован.");
            }
            catch (Exception ex)
            {
                return UserResponse.Error("Произошла ошибка при добавлении пользователя: " + ex.Message);
            }
        }
        public UserResponse AuthenticateUser(UserAuth userModel)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand(
                        "SELECT * FROM auth.authenticate_user(@login, @password)",
                        connection
                    ))
                    {
                        command.Parameters.AddWithValue("@login", userModel.Login);
                        command.Parameters.AddWithValue("@password", userModel.Password);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var userData = new UserData
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                                    Name = $"{reader.GetString(reader.GetOrdinal("first_name"))} {reader.GetString(reader.GetOrdinal("middle_name"))} {reader.GetString(reader.GetOrdinal("last_name"))}",
                                    Email = reader.GetString(reader.GetOrdinal("mail")),
                                    Token = GenerateJwtToken(reader.GetInt32(reader.GetOrdinal("id")))
                                };

                                return UserResponse.Success("Success", userData);

                            }
                            else
                            {
                                return UserResponse.Error("Неверные учетные данные");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return UserResponse.Error("Произошла ошибка при аутентификации: " + ex.Message);
            }
        }




        // Метод для генерации JWT-токена
        private string GenerateJwtToken(int userId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
            new Claim(ClaimTypes.Name, userId.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
