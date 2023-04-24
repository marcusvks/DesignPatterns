using FactoryMethodPattern.A_FabricaConstrucaoDatabases;
using FactoryMethodPattern.Conectores;


namespace FactoryMethodPattern.Fabricas
{
    public class OracleFactory : DatabaseFactory
    {
        public override DatabaseConnectors CriarConexao(string connectionString)
        {
            return new OracleConnector(connectionString);
        }
    }
}
