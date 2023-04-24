using ObserverPattern.Enum;
using ObserverPattern.Implementacoes;
using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern.Implementacoes
{
    //Entenda esta classe como:
    //"Objeto Que Sofrerá Mudança e Que Precisa Notificar Outro Objeto Para Aquele Realizar Alguma Ação"
    public class Nome : IObjetoObservado
    {
        private string _nome;
        public TipoAcao TipoAcao { get; set; }

        public List<IObjetoParaAtualizar> objetosObservados;

        public string nome
        {
            get { return _nome; }
            set { _nome = value; NotificarMudancas(); }
        }

        public Nome()
        {
            objetosObservados = new List<IObjetoParaAtualizar>();
        }

        //Necessário sempre Adicionar o Objeto que Precisa ser Notificado
        public void AdicionarObjetoParaSerNotificado(IObjetoParaAtualizar objetoParaObservar)
        {
            objetosObservados.Add(objetoParaObservar);
        }

        //Toda vez Que Este Objeto Sofrer uma Ação de "SET" ele Irá Notificar essa Mudança aos Objetos Interessados.
        public void NotificarMudancas()
        {
            objetosObservados.ForEach(o =>
            {
                o.AtualizarObjeto(this, TipoAcao);
            });
        }

    }
}
