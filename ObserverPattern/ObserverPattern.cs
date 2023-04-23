using ObserverPattern.Implementacoes;
using System;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class ObserverPattern : Form
    {
        private Nome _classeNome;
        private ListaDoComponente _classeListaDoComponente;
        private TextBoxNomeTempoReal _listBoxNomeTempoReal;

        public ObserverPattern()
        {
            InitializeComponent();

            _classeNome = new Nome();
            _classeListaDoComponente = new ListaDoComponente(listNome);
            _listBoxNomeTempoReal = new TextBoxNomeTempoReal(textNomeTempoReal);

            _classeNome.AdicionarObjetoParaSerNotificado(_listBoxNomeTempoReal);
            _classeNome.AdicionarObjetoParaSerNotificado(_classeListaDoComponente);
        }

        private void btnAddNome_Click(object sender, EventArgs e)
        {
            _classeNome.TipoAcao = Enum.TipoAcao.AcaoSalvar;
            _classeNome.nome = txtNome.Text;
            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            _classeNome.TipoAcao = Enum.TipoAcao.AcaoAtualizarTempoReal;
            _classeNome.nome = txtNome.Text;
            
        }
    }
}
