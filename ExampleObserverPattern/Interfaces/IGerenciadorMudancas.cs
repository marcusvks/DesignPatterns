namespace ExampleObserverPattern.Interfaces
{
    public interface IGerenciadorMudancas
    {
        void AdicionarObjetoQuePrecisaSerNotificado(IObjetoParaSerObservado observer);
        void NotificarObjetos();
    }
}
