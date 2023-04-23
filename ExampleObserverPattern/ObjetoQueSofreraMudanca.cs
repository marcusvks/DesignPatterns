using ExampleObserverPattern.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExampleObserverPattern
{
    public class ObjetoQueSofreraMudanca : IGerenciadorMudancas
    {
        private List<IObjetoParaSerObservado> observers = new List<IObjetoParaSerObservado>();
        private float _temperatura;

        public float Temperatura
        { 
            get { return _temperatura; }
            set { _temperatura = value; NotificarObjetos();}
        }

        public void AdicionarObjetoQuePrecisaSerNotificado(IObjetoParaSerObservado observer)
        {
            observers.Add(observer);
        }

        public void NotificarObjetos()
        {
            observers.ForEach(o =>
            {
                o.AtualizarObjetoTempoReal(this);
            });
        }
    }
}
