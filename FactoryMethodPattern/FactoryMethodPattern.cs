using FactoryMethodPattern.A_FabricaConstrucaoDatabases;
using FactoryMethodPattern.Conectores;
using FactoryMethodPattern.Enums;
using System;
using System.Windows.Forms;

namespace FactoryMethodPattern
{
    public partial class FactoryMethodPattern : Form
    {
        private DatabaseTypes _bancoSelecionado;

        public FactoryMethodPattern()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (ValidacoesBasicas())
            {

                Connection coneccao = DatabaseFactory.SelecionarBancoDeDados(_bancoSelecionado) //Passa o Banco de Dados que Deseja
                               .CriarConexao(tbStringConexao.Text) //Passa a String de Conexao do Banco de Dados
                               .Conectar(); //Se conectara ao BD Selecionado

                coneccao.ExecuteCommand("Comando de Teste");
                coneccao.Close();
            }

        }

        private bool ValidacoesBasicas()
        {

            if (string.IsNullOrEmpty(tbStringConexao.Text))
            {
                MessageBox.Show("A CS Nao pode Nula ou Vazia");
                return false;
            }

            else if (!cbMySql.Checked && !cbOracle.Checked && !cbSqlServer.Checked)
            {
                MessageBox.Show("Selecione o Banco de Dados");
                return false;
            }
            else
                return true;
        }

        private void cbMySql_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMySql.Checked)
            {
                _bancoSelecionado = DatabaseTypes.MySql;
                cbOracle.Enabled = false;
                cbSqlServer.Enabled = false;
            }
            else
            {
                cbOracle.Enabled = true;
                cbSqlServer.Enabled = true;
            }
        }

        private void cbOracle_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOracle.Checked)
            {
                _bancoSelecionado = DatabaseTypes.Oracle;
                cbMySql.Enabled = false;
                cbSqlServer.Enabled = false;
            }
            else
            {
                cbMySql.Enabled = true;
                cbSqlServer.Enabled = true;
            }
        }

        private void cbSqlServer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSqlServer.Checked)
            {
                _bancoSelecionado = DatabaseTypes.SqlServer;
                cbMySql.Enabled = false;
                cbOracle.Enabled = false;
            }
            else
            {
                cbMySql.Enabled = true;
                cbOracle.Enabled = true;
            }
        }
    }
}
