
using FacadePattern.Implementacoes.Bebidas.BebidasAlcoolicas;
using FacadePattern.Implementacoes.Bebidas.BebidasNaoAlcoolicas;
using FacadePattern.Implementacoes.Lanches.LanchesDeCarne;
using FacadePattern.Implementacoes.Lanches.LanchesDeFrango;
using FacadePattern.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FacadePattern.Implementacoes.Facade
{
    public class RestauranteFacadeImpl : IRestauranteFacade
    {
        private IBebidas _bebidasNaoAlcoolicas;
        private IBebidas _bebidasAlcoolicas;

        private ILanche _lanchesDeCarne;
        private ILanche _lanchesDeFrango;

        private IServiceProvider _serviceProvider;

        public RestauranteFacadeImpl(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _bebidasAlcoolicas = _serviceProvider.GetServices<IBebidas>().First(o => o.GetType() == typeof(BebidasAlcoolicasImpl));
            _bebidasNaoAlcoolicas = _serviceProvider.GetServices<IBebidas>().First(o => o.GetType() == typeof(BebidasNaoAlcoolicasImpl));

            _lanchesDeCarne = _serviceProvider.GetServices<ILanche>().First(o => o.GetType() == typeof(LanchesDeCarneImpl));
            _lanchesDeFrango = _serviceProvider.GetServices<ILanche>().First(o => o.GetType() == typeof(LanchesDeFrangoImpl));
        }

        public List<string> BuscarBebidasAlcoolicas()
        {          
            return _bebidasAlcoolicas.BuscarTodasAsBebidas();
        }

        public List<string> BuscarBebidasNaoAlcoolicas()
        {                
            return _bebidasNaoAlcoolicas.BuscarTodasAsBebidas();
        }

        public List<string> BuscarLanchesDeCarne()
        {
            return _lanchesDeCarne.BuscarTodosOsLanches();
        }

        public List<string> BuscarLanchesDeFrango()
        {
            return _lanchesDeFrango.BuscarTodosOsLanches();
        }
    }
}
