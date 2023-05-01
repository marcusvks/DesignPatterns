using AbstractFactoryPatternRealLife.AbstractFactoryExtension;
using AbstractFactoryPatternRealLife.Implementacoes;
using AbstractFactoryPatternRealLife.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace AbstractFactoryPatternRealLife
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            // Padrao
            serviceCollection.AddTransient<IDataHora, DataHoraImpl>();

            // Factory -> chama o metodo de pegar uma nova instancia sempre que preciso
            serviceCollection.AddSingleton<Func<IDataHora>>(x => () => x.GetService<IDataHora>());

            // Abstract Factory -> Resolução Reutilizavel e mais elegante
            serviceCollection.AbstractFactory<IDataHora, DataHoraImpl>();

            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AbstractFactoryPattern(serviceProvider));
        }
    }
}
