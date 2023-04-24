using System;
using System.Windows.Forms;

namespace FactoryMethodPattern.Conectores
{
    public class MySqlConnector : DatabaseConnectors
    {
        public MySqlConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Conectar()
        {
            MessageBox.Show($"Conectando ao banco MySql com a CS: {ConnectionString}");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
