using Npgsql;

namespace ApiForAuth.Helper
{
    public static class PostgreSqlHelper
    {

        public static NpgsqlCommand CreateCommand(this string connectionString, 
                string sql, 
                IEnumerable<KeyValuePair<string, object>> parameters = null,
                IEnumerable<NpgsqlParameter> specialParameters = null
            )
        {
            if (string.IsNullOrWhiteSpace(connectionString)) throw new ArgumentNullException("connectionString");
            if (string.IsNullOrWhiteSpace(sql)) throw new ArgumentNullException("sql");

            NpgsqlCommand command = new NpgsqlConnection(connectionString).CreateCommand();
            command.CommandTimeout = 60 * 60 * 60;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;

            if (parameters != null && parameters.Any())
            {
                parameters.ToList().ForEach(
                    x => { command.Parameters.AddWithValue(x.Key, x.Value ?? DBNull.Value); }
                );
            }
            if (specialParameters != null && specialParameters.Any())
            {
                specialParameters.ToList().ForEach(
                    x => { command.Parameters.Add(x); }
                );
            }

            return command;
        }


        public static void ExecuteNonQuery(this string connectionString, 
                string sql, 
                IEnumerable<KeyValuePair<string, object>> parameters = null,
                IEnumerable<NpgsqlParameter> specialParameters = null
            )
        {
            NpgsqlCommand command = connectionString.CreateCommand(sql, parameters, specialParameters);
            using (command.Connection)
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

    }
}
