using System;
using System.Windows.Forms;

namespace FactoryMethodPattern.Conectores
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        public bool Opened { get; set; }

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void ExecuteCommand(string command)
        {
            MessageBox.Show("Executando Commando: " + command);
        }

        public void Open()
        {
            Opened = true;
            MessageBox.Show("Conexão aberta");
        }

        public void Close()
        {
            MessageBox.Show("Conexão fechada");
        }
    }
}