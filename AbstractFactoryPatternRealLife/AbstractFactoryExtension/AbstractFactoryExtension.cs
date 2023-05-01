using AbstractFactoryPatternRealLife.Implementacoes;
using AbstractFactoryPatternRealLife.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AbstractFactoryPatternRealLife.AbstractFactoryExtension
{
    public static class AbstractFactoryExtension
    {
        public static void AbstractFactory<TInterface, TImplementacao>(this IServiceCollection services)
            where TInterface : class
            where TImplementacao : class, TInterface
        {
            services.AddTransient<IDataHora, DataHoraImpl>();
            services.AddSingleton<Func<IDataHora>>(x => () => x.GetService<IDataHora>());
            services.AddSingleton<IAbstractFactory<TInterface>, AbstractFactoryImpl<TInterface>>();
        }
    }
}
