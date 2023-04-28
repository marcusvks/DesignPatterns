using ObserverPattern.Enum;
using ObserverPattern.Interfaces;
using System.Windows.Forms;

namespace ObserverPattern.Implementacoes
{
    //Entenda esta classe como:
    //"Objeto Que Precisará ser Notificado Para Realizar Alguma Ação a Partir da Mudança do Estado de Outro Objeto"
    public class ListaDoComponente : IObjetoParaAtualizar
    {
        private ListBox _listComponente;

        public ListaDoComponente(ListBox listComponente)
        => (_listComponente) = (listComponente);

        public void AtualizarObjeto(IObjetoObservado objeto, TipoAcao TipoAcao)
        {
            if (objeto is Nome classeNome && TipoAcao == TipoAcao.AcaoSalvar)
            {
                _listComponente.Items.Add(classeNome.nome);
            }
        }
    }
}
