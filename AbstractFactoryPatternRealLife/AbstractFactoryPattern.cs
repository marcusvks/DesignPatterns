using AbstractFactoryPatternRealLife.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace AbstractFactoryPatternRealLife
{
    public partial class AbstractFactoryPattern : Form
    {
        private IServiceProvider _serviceProvider;

        //Padrao
        private IDataHora _dataHora;

        //Factory
        private Func<IDataHora> _dataHoraFactory;

        //Abstract Factory
        private IAbstractFactory<IDataHora> _dataHoraAbstractFactory;

        public AbstractFactoryPattern(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            //DI Injetada por Padrao
            _dataHora = _serviceProvider.GetService<IDataHora>();

            //Factory -> Pegar sempre uma instancia nova (olhe no program)
            _dataHoraFactory = serviceProvider.GetService<Func<IDataHora>>();

            //AbstractFactory -> Jeito Reutilizavel mais elegante
            _dataHoraAbstractFactory = serviceProvider.GetService<IAbstractFactory<IDataHora>>();

            InitializeComponent();
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            tb_data.Text = _dataHora.InformarDataHoraAtuais();
        }

        private void btn_dataFactory_Click(object sender, EventArgs e)
        {
            //Pegue uma nova instancia toda vez que o botao for clicado
            tb_dataFactory.Text = _dataHoraFactory().InformarDataHoraAtuais(); 
        }

        private void btn_dataAbstractFactory_Click(object sender, EventArgs e)
        {
            tb_dataBastractFactory.Text = _dataHoraAbstractFactory.Criar().InformarDataHoraAtuais();
        }

    }
}
