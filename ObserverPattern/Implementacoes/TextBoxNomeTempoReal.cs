using ObserverPattern.Enum;
using System.Windows.Forms;

namespace ObserverPattern.Implementacoes
{
    public class TextBoxNomeTempoReal : IObjetoParaAtualizar
    {
        private TextBox _nomeTempoReal;

        public TextBoxNomeTempoReal(TextBox nomeTempoReal)
        => (_nomeTempoReal) = (nomeTempoReal);

        public void AtualizarObjeto(IObjetoObservado objeto, TipoAcao TipoAcao)
        {
            if (objeto is Nome classeNome && TipoAcao == TipoAcao.AcaoAtualizarTempoReal)
            {
                _nomeTempoReal.Text = classeNome.nome;
            }
        }
    }
}
