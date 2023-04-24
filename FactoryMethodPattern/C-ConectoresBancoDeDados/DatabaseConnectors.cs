

namespace FactoryMethodPattern.Conectores
{
    public abstract class DatabaseConnectors
    {
        protected string ConnectionString { get; set; }
        public abstract Connection Conectar();

        protected DatabaseConnectors(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
