using DesignPatterns;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StructuralPatternsProject
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<ILogger, LoggerImpl>();
            serviceCollection.AddTransient<ILoggerNovo, LoggerNovoImpl>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdapterForm(serviceCollection));
        }
        
    }
}
