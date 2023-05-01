using FacadePattern.Interfaces;
using System.Collections.Generic;

namespace FacadePattern.Implementacoes.Bebidas.BebidasNaoAlcoolicas
{
    public class BebidasNaoAlcoolicasImpl : IBebidas
    {
        private List<string> _bebidasNaoAlcoolicas;

        public BebidasNaoAlcoolicasImpl()
        {
            _bebidasNaoAlcoolicas = new List<string>()
            {
                "Coca Cola",
                "Pepsi",
                "Guarana",
                "Fanta",
                "Sprite",
                "Agua Mineral",
                "Itubaina"
            };
        }
        public List<string> BuscarTodasAsBebidas()
        {
            return _bebidasNaoAlcoolicas;
        }
    }
}
