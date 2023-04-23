using ObserverPattern.Implementacoes;
using System;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class ObserverPattern : Form
    {
        private Nome _classeNome;
        private ListaDoComponente _classeListaDoComponente;

        public ObserverPattern()
        {
            InitializeComponent();

            _classeNome = new Nome();
            _classeListaDoComponente = new ListaDoComponente(listNome);
        }

        private void btnAddNome_Click(object sender, EventArgs e)
        {

            _classeNome.AdicionarObjetoParaSerNotificado(_classeListaDoComponente);
            _classeNome.nome = txtNome.Text;
        }

    }
}
