using AbstractFactoryPatternRealLife.Interfaces;
using System;

namespace AbstractFactoryPatternRealLife.Implementacoes
{
    public class DataHoraImpl : IDataHora
    {
        private string _dataHora { get; set; }

        public DataHoraImpl()
        {
            _dataHora = DateTime.Now.ToString("T");
        }

        public string InformarDataHoraAtuais()
        {
            return _dataHora;
        }
    }
}
