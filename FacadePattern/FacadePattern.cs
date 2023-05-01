using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using FacadePattern.Interfaces;

namespace FacadePattern
{
    public partial class FacadePattern : Form
    {
        private IRestauranteFacade _restauranteFacadeBebidas;
        private IServiceProvider _serviceProvider;

        public FacadePattern(IServiceCollection serviceCollection)
        {
            _serviceProvider = serviceCollection.BuildServiceProvider();
            _restauranteFacadeBebidas = _serviceProvider.GetService<IRestauranteFacade>();
            InitializeComponent();

        }

        private void btn_verCardapio_Click(object sender, EventArgs e)
        {
            ExibirBebidas();
            ExibirLanches();
        }

        private void ExibirBebidas()
        {
            //Facade
            var bebidasNaoAlcoolicas = _restauranteFacadeBebidas.BuscarBebidasNaoAlcoolicas();
            var bebidasAlcoolicas = _restauranteFacadeBebidas.BuscarBebidasAlcoolicas();

            var bebidaNaoAlcoolica = list_bebidas.Nodes.Add("BEBIDAS NAO ALCOOLICAS");
            foreach (var bebida in bebidasNaoAlcoolicas)
            {
                bebidaNaoAlcoolica.Nodes.Add(bebida);
                bebidaNaoAlcoolica.ExpandAll();
            }

            var bebidaAlcoolica = list_bebidas.Nodes.Add("BEBIDAS ALCOOLICAS");
            foreach (var bebida in bebidasAlcoolicas)
            {
                bebidaAlcoolica.Nodes.Add(bebida);
                bebidaAlcoolica.ExpandAll();
            }
        }

        private void ExibirLanches()
        {
            //Facade
            var lanchesCarne = _restauranteFacadeBebidas.BuscarLanchesDeCarne();
            var lanchesFrango = _restauranteFacadeBebidas.BuscarLanchesDeFrango();

            var lancheCarne = list_lanches.Nodes.Add("LANCHES DE CARNE");
            foreach (var lanche in lanchesCarne)
            {
                lancheCarne.Nodes.Add(lanche);
                lancheCarne.ExpandAll();
            }

            var lancheFrango = list_lanches.Nodes.Add("LANCHES DE FRANGO");
            foreach (var lanche in lanchesFrango)
            {
                lancheFrango.Nodes.Add(lanche);
                lancheFrango.ExpandAll();
            }
        }
    }
}
