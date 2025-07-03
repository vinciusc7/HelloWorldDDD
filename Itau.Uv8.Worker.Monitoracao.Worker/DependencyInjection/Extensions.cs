using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itau.Uv8.Worker.Monitoracao.Domain.Interfaces;
using Itau.Uv8.Worker.Monitoracao.Infrastructure.Repositories;
using Itau.Uv8.Worker.Monitoracao.Services.Services;
using Itau.Uv8.Worker.Monitoracao.Services.Use_cases;

namespace Itau.Uv8.Worker.Monitoracao.Worker.DependencyInjection
{
    public static class Extensions
    {
        public static IServiceCollection AddMonitoracaoDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IMensagemRepository, MensagemRepository>();
            services.AddSingleton<MensagemService>();
            services.AddSingleton<ObterMensagemUseCase>();

            return services; 
        }
    }
}