using Itau.Uv8.Worker.Monitoracao.Domain.Interfaces;
using Itau.Uv8.Worker.Monitoracao.Infrastructure.Repositories;
using Itau.Uv8.Worker.Monitoracao.Services.Services;
using Itau.Uv8.Worker.Monitoracao.Services.Use_cases;
using Itau.Uv8.Worker.Monitoracao.Worker.DependencyInjection;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddMonitoracaoDependencies();

using var host = builder.Build();

using var scope = host.Services.CreateScope();
var useCase = scope.ServiceProvider.GetRequiredService<ObterMensagemUseCase>();
var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();


string mensagem = useCase.Executar();


logger.LogInformation(mensagem);