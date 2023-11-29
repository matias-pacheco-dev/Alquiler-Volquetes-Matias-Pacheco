using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public abstract class MyConnectionToSql
    {
        private readonly string connectionString;


        public MyConnectionToSql()
        {
            connectionString = @"Server=localhost;Database=usuarios-volquete;Uid=root;Pwd=;";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }


    }
}