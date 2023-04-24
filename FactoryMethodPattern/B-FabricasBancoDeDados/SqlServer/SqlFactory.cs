using FactoryMethodPattern.A_FabricaConstrucaoDatabases;
using FactoryMethodPattern.Conectores;


namespace FactoryMethodPattern.Fabricas
{
    public class SqlFactory : DatabaseFactory
    {
        public override DatabaseConnectors CriarConexao(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}
