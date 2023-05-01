using AbstractFactoryPatternRealLife.Interfaces;
using System;

namespace AbstractFactoryPatternRealLife.Implementacoes
{
    public class AbstractFactoryImpl<T> : IAbstractFactory<T>
    {
        private readonly Func<T> _factory;

        public AbstractFactoryImpl(Func<T> factory)
        {
            _factory = factory;
        }

        public T Criar()
        {
            return _factory();
        }
    }
}
