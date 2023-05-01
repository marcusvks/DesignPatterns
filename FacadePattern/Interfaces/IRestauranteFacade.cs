

using System.Collections.Generic;

namespace FacadePattern.Interfaces
{
    public interface IRestauranteFacade
    {
        List<string> BuscarLanchesDeCarne();
        List<string> BuscarLanchesDeFrango();

        List<string> BuscarBebidasNaoAlcoolicas();
        List<string> BuscarBebidasAlcoolicas();
    }
}
