using FacadePattern.Implementacoes;
using FacadePattern.Implementacoes.Bebidas.BebidasAlcoolicas;
using FacadePattern.Implementacoes.Bebidas.BebidasNaoAlcoolicas;
using FacadePattern.Implementacoes.Facade;
using FacadePattern.Implementacoes.Lanches.LanchesDeCarne;
using FacadePattern.Implementacoes.Lanches.LanchesDeFrango;
using FacadePattern.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace FacadePattern
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IBebidas, BebidasNaoAlcoolicasImpl>();
            serviceCollection.AddTransient<IBebidas, BebidasAlcoolicasImpl>();

            serviceCollection.AddTransient<ILanche, LanchesDeFrangoImpl>();
            serviceCollection.AddTransient<ILanche, LanchesDeCarneImpl>();

            serviceCollection.AddTransient<IRestauranteFacade, RestauranteFacadeImpl>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FacadePattern(serviceCollection));
        }
    }
}
