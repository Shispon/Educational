using AuthAndLogs.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Text;


namespace AuthAndLogs.Repositories
{

    public interface ILogsRepository
    {
        IEnumerable<LogsModel> Select();
        bool Insert(string message, string ip, string route);
       
    }
    public class LogsRepository : ILogsRepository
    {
        private readonly string _connectionString;

        public LogsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<LogsModel> Select()
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            List<LogsModel> logs = new List<LogsModel>();
            using (var connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var command = new NpgsqlCommand("select * from auth.logs", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    byte[] fileBytes = reader.IsDBNull(3) ? null : reader.GetFieldValue<byte[]>(3);

                    string fileContent = Encoding.UTF8.GetString(fileBytes);
                    var log = new LogsModel
                    {
                        Id = reader.GetInt32(0),
                        Ip = reader.GetString(1),
                        DateCreate = reader.GetDateTime(2),
                        route = reader.GetString(4),
                        Message = fileContent,
                    };
                    logs.Add(log);
                }
                connection.Close();
            }
            return logs;
        }


        public bool Insert(string message, string ip, string route)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            using (var connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                string filePath = "log.txt";
                System.IO.File.WriteAllText(filePath, message + " " +ip + " " + DateTime.Now.ToString());
                byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
                var command = new NpgsqlCommand("insert into auth.logs (ip,date_create,message,route) values (@ip,@date_create,@message,@route)", connection);
                command.Parameters.AddWithValue("ip", ip);
                command.Parameters.AddWithValue("date_create", DateTime.Now);
                command.Parameters.AddWithValue("message", message);
                command.Parameters.AddWithValue("route", route);
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }
    }
       
    
}
