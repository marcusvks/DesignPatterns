using FacadePattern.Interfaces;
using System.Collections.Generic;

namespace FacadePattern.Implementacoes.Bebidas.BebidasAlcoolicas
{
    public class BebidasAlcoolicasImpl : IBebidas
    {
        private List<string> _bebidasAlcoolicas;

        public BebidasAlcoolicasImpl()
        {
            _bebidasAlcoolicas = new List<string>()
            {
                "Cerveja Skol",
                "Cerveja Kaiser",
                "Vinho Tinto",
                "Vinho Branco",
                "Vinho Seco",
                "Whisky Red Label",
                "Whisky Blue Label"
            };
        }

        public List<string> BuscarTodasAsBebidas()
        {
            return _bebidasAlcoolicas;
        }
    }
}
