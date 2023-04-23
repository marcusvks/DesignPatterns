using ObserverPattern.Implementacoes;

namespace ObserverPattern
{
    //Entenda esta classe como:
    //"Objeto Que Sofrerá Mudança e Que Precisa Notificar Outro Objeto Para Aquele Realizar Alguma Ação"
    public class Nome : IObjetoObservado
    {
        private string _nome;
        public IObjetoParaAtualizar objetosObservados;

        public string nome
        {
            get { return _nome; }
            set { _nome = value; NotificarMudancas(); }
        }
        
        //Necessário sempre Adicionar o Objeto que Precisa ser Notificado
        public void AdicionarObjetoParaSerNotificado(IObjetoParaAtualizar objetoParaObservar)
        {
            objetosObservados = objetoParaObservar;
        }

        //Toda vez Que Este Objeto Sofrer uma Ação de "SET" ele Irá Notificar essa Mudança aos Objetos Interessados.
        public void NotificarMudancas()
        {
            objetosObservados.AtualizarObjeto(this);
        }

    }
}
