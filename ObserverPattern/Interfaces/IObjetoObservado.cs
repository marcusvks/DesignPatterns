using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Implementacoes
{
    public interface IObjetoObservado
    {
        void AdicionarObjetoParaSerNotificado(IObjetoParaAtualizar objetosObservados);
        void NotificarMudancas();
    }
}
