using FacadePattern.Interfaces;
using System.Collections.Generic;

namespace FacadePattern.Implementacoes.Lanches.LanchesDeCarne
{
    public class LanchesDeCarneImpl : ILanche
    {
        private List<string> _lanchesDeCarne;

        public LanchesDeCarneImpl()
        {
            _lanchesDeCarne = new List<string>()
            {
                "Xis Picanha",
                "Xis Alcatra",
                "Xis Coração",
                "Xis Costela",
                "Xis Picanha Com Costela",
                "Xis Alcatra com Costela",
                "Xis Coração com Costela"
            };
        }

        public List<string> BuscarTodosOsLanches()
        {
            return _lanchesDeCarne;
        }
    }
}
