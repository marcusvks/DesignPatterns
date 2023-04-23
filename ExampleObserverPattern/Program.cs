using System;

namespace ExampleObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjetoQueSofreraMudanca objetoQueSofreraMudança = new ObjetoQueSofreraMudanca();

            ObjetoQuePrecisaSerAtualizadoEmTempoReal classePrecisaSerAtualizada = new ObjetoQuePrecisaSerAtualizadoEmTempoReal("Agencia de Noticia de São Paulo");
            ObjetoQuePrecisaSerAtualizadoEmTempoReal classePrecisaSerAtualizada2 = new ObjetoQuePrecisaSerAtualizadoEmTempoReal("Agencia de Noticia de Suzano");

            objetoQueSofreraMudança.AdicionarObjetoQuePrecisaSerNotificado(classePrecisaSerAtualizada);
            objetoQueSofreraMudança.AdicionarObjetoQuePrecisaSerNotificado(classePrecisaSerAtualizada2);

            objetoQueSofreraMudança.Temperatura = 31.4f;
            objetoQueSofreraMudança.Temperatura = 25f;
            objetoQueSofreraMudança.Temperatura = 26.7f;
            objetoQueSofreraMudança.Temperatura = 34.7f;
            objetoQueSofreraMudança.Temperatura = 22.7f;
            objetoQueSofreraMudança.Temperatura = 15.7f;

            Console.ReadLine();
        }
    }
}
