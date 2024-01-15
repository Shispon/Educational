using AuthAndLogs.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace AuthAndLogs.Repositories
{
    public interface IAuthRepository
    {
        IEnumerable<AuthModel> Select();
        bool Insert(string login, string name, string mail, string password, string phone);
        bool Login( string login ,string password);
    }

    public class AuthRepository: IAuthRepository
    {
        private readonly string _connectionString;

        public AuthRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<AuthModel> Select()
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            List<AuthModel> auths = new List<AuthModel>();
            using (var connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var command = new NpgsqlCommand("select * from auth.user", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var auth = new AuthModel
                    {
                        Id = reader.GetInt32(0),
                        Login = reader.GetString(1),
                        Name = reader.GetString(2),
                        Email = reader.GetString(3),
                        Password = reader.GetString(4), 
                        Phone = reader.GetString(5),
                    };
                    auths.Add(auth);
                }
                connection.Close();
            }
            return auths;
        }


        public bool Insert(string login, string name, string mail, string password, string phone)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            using (var connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var checkCommand = new NpgsqlCommand("select count(*) from auth.user where login = @login", connection);
                checkCommand.Parameters.AddWithValue("login", login);
                var existingCount = (Int64)checkCommand.ExecuteScalar();

                if (existingCount > 0)
                {

                    return false;
                }
                var command = new NpgsqlCommand("insert into auth.user (login,name,mail,password,phone_number) values (@login,@name,@mail,@password,@phone_number)", connection);
                command.Parameters.AddWithValue("login", login);
                command.Parameters.AddWithValue("name", name);
                command.Parameters.AddWithValue("mail", mail);
                command.Parameters.AddWithValue("password", password);
                command.Parameters.AddWithValue("phone_number", phone);
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        public bool Login(string login, string password) 
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            using (var connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                var checkCommand = new NpgsqlCommand("select count(*) from auth.user where login = @login", connection);
                checkCommand.Parameters.AddWithValue("login", login);
                var existingCount = (Int64)checkCommand.ExecuteScalar();

                if (existingCount == 0)
                {
                    // Логин не существует, возвращаем false
                    return false;
                }

                var checkCommand1 = new NpgsqlCommand("SELECT password FROM auth.user WHERE login = @login", connection);
                checkCommand1.Parameters.AddWithValue("login", login);
                var passwordFromDB = (string)checkCommand1.ExecuteScalar();

                // Проверяем, соответствует ли пароль
                return passwordFromDB.Equals(password);
            }
        }
                
    }
}
