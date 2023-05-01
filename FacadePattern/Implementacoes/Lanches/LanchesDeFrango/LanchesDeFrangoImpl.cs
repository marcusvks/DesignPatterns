using FacadePattern.Interfaces;
using System.Collections.Generic;

namespace FacadePattern.Implementacoes.Lanches.LanchesDeFrango
{
    public class LanchesDeFrangoImpl : ILanche
    {
        private List<string> _lanchesDeFrango;

        public LanchesDeFrangoImpl()
        {
            _lanchesDeFrango = new List<string>()
            {
                "Xis Frango com Catupiry",
                "Xis Frango com Cheddar",
                "Xis Frango Xadrez",
                "Xis Frango com Bacon",
                "Xis Frango com Calabresa",
                "Xis Frango com Bacon e Calabresa",
                "Xis Tudo Frango"
            };
        }

        public List<string> BuscarTodosOsLanches()
        {
            return _lanchesDeFrango;
        }
    }
}
