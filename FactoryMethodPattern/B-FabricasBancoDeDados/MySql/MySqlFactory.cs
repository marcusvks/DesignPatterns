using FactoryMethodPattern.A_FabricaConstrucaoDatabases;
using FactoryMethodPattern.Conectores;

namespace FactoryMethodPattern.Fabricas
{
    public class MySqlFactory : DatabaseFactory
    {
        public override DatabaseConnectors CriarConexao(string connectionString)
        {
            return new MySqlConnector(connectionString);
        }
    }
}
