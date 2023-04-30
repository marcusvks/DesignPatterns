using FactoryMethodPattern.A_FabricaConstrucaoDatabases;
using FactoryMethodPattern.Enums;
using FactoryMethodPattern.Fabricas;
using System;

namespace FactoryMethodPattern.Extensoes
{
    public static class DatabaseTypeExtentions
    {
        public static DatabaseFactory SelectDatabase(this DatabaseTypes databaseTypes)
        {
            if (databaseTypes == DatabaseTypes.SqlServer)
                return new SqlFactory();
            if (databaseTypes == DatabaseTypes.Oracle)
                return new OracleFactory();
            if (databaseTypes == DatabaseTypes.MySql)
                return new MySqlFactory();

            throw new ApplicationException("Banco de dados não reconhecido.");
        }
    }
}
