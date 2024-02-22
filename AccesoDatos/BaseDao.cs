using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class BaseDao<T>
    {
        protected MySqlConnection GetConnection()
        {
            // Mantén la lógica original para obtener la conexión
            return new MySqlConnection(@"Server=localhost;Database=usuarios-volquete;Uid=root;Pwd=;");
        }
        public List<T> ExecuteQuery(string query, Dictionary<string, object> parameters = null, Func<MySqlDataReader, T> mapFunction = null)
        {
            List<T> results = new List<T>();

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;

                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    command.CommandType = CommandType.Text;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T result = mapFunction != null ? mapFunction(reader) : default(T);
                            results.Add(result);
                        }
                    }
                }
            }

            return results;
        }

        protected int ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;

                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    command.CommandType = CommandType.Text;

                    int? result = command.ExecuteScalar() as int?;
                    return result.HasValue ? result.Value : 0;
                }
            }
        }
        public void ExecuteReader(string query, Dictionary<string, object> parameters, Action<MySqlDataReader> action)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;

                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    command.CommandType = CommandType.Text;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        action(reader);
                    }
                }
            }
        }
    }
}
