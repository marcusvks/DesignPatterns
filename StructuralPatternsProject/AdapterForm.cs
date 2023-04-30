using DesignPatterns;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace StructuralPatternsProject
{
    public partial class AdapterForm : Form
    {
        private IServiceProvider _serviceProvider;
        private ILogger _logger;
        private IServiceCollection _serviceCollection;
        private bool _necessarioVoltarDependenciaOriginal;

        public AdapterForm(IServiceCollection serviceCollection)
        {
            _serviceProvider = serviceCollection.BuildServiceProvider();
            _serviceCollection = serviceCollection;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!rb_logPadrao.Checked && !rb_logNovo.Checked)
                MessageBox.Show("Selecione um Tipo de Log Para Utilizar");

            else
            {

                if (rb_logPadrao.Checked)
                {
                    VerificaDependenciaOriginal();
                    _logger = _serviceProvider.GetService<ILogger>();

                    string logPadrao = _logger.LogInfo("Logando informações do log PADRAO ja existente");

                    lb_logUnico.Items.Add(logPadrao); //Lista Unica
                    lb_LogPadrao.Items.Add(logPadrao); //Lista so do log padrao
                }

                else if (rb_logNovo.Checked)
                {
                    TrocarInjecaoDependenciaLogNovo();
                    _logger = _serviceProvider.GetService<ILogger>();

                    string logNovo = _logger.LogInfo("Logando informações do log NOVO");

                    lb_logUnico.Items.Add(logNovo); //Lista Unica
                    lb_LogNovo.Items.Add(logNovo); //Lista so do log novo

                    _necessarioVoltarDependenciaOriginal = true;
                }
            }
        }

        private void VerificaDependenciaOriginal()
        {
            if (_necessarioVoltarDependenciaOriginal)
            {
                ConfirmarInjecaoDependenciaLogPadrao();
                _necessarioVoltarDependenciaOriginal = false;
            }              
        }

        private void TrocarInjecaoDependenciaLogNovo()
        {
            //Substitui a injeção de dependencia da classe Antiga para a classe Nova, ##utilizando a mesma interface##
            var descriptor = new ServiceDescriptor(typeof(ILogger), typeof(AdapterImpl), ServiceLifetime.Transient);
            _serviceCollection.Replace(descriptor);
            _serviceProvider = _serviceCollection.BuildServiceProvider();
        }
        private void ConfirmarInjecaoDependenciaLogPadrao()
        {
            //Apenas garante a injeção de dependencia original quando voltar a clicar no botao.
            var descriptor = new ServiceDescriptor(typeof(ILogger), typeof(LoggerImpl), ServiceLifetime.Transient);
            _serviceCollection.Replace(descriptor);
            _serviceProvider = _serviceCollection.BuildServiceProvider();
        }
    }
}
