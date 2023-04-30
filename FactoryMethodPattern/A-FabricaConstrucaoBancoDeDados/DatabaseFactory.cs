using FactoryMethodPattern.Conectores;
using FactoryMethodPattern.Enums;
using FactoryMethodPattern.Extensoes;
using FactoryMethodPattern.Fabricas;
using System;

namespace FactoryMethodPattern.A_FabricaConstrucaoDatabases
{
    //1 - Classe Base que Será Utilizada
    public abstract class DatabaseFactory
    {      
        //3 - Com base no que foi Instanciado vai ser Criado a Conexao Especifica
        public abstract DatabaseConnectors CriarConexao(string connectionString);

        //2 - Vai ser Criado uma Instancia do Banco de Dados Passado
        public static DatabaseFactory SelecionarBancoDeDados(DatabaseTypes dataBase)
        {
            return dataBase.SelectDatabase();
        }
    }
}
