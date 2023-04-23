using ExampleObserverPattern.Interfaces;
using System;

namespace ExampleObserverPattern
{
    public class ObjetoQuePrecisaSerAtualizadoEmTempoReal : IObjetoParaSerObservado
    {
        public string NomeAgencia { get; set; }

        public ObjetoQuePrecisaSerAtualizadoEmTempoReal(string NomeAgencia)
        {
            this.NomeAgencia = NomeAgencia;
        }
        public void AtualizarObjetoTempoReal(IGerenciadorMudancas subject)
        {
            if (subject is ObjetoQueSofreraMudanca estacaoMeteorologica)
            {
                Console.WriteLine(string.Format("{0} reportando a temperatura {1} graus celsius", NomeAgencia, estacaoMeteorologica.Temperatura));
                Console.WriteLine();
            }
        }
    }
}
