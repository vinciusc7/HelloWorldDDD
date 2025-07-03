using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itau.Uv8.Worker.Monitoracao.Domain.Entities;
using Itau.Uv8.Worker.Monitoracao.Domain.Interfaces;
using Itau.Uv8.Worker.Monitoracao.Services.Services;

namespace Itau.Uv8.Worker.Monitoracao.Services.Use_cases
{
    public class ObterMensagemUseCase
    {
        private readonly IMensagemRepository _mensagemRepository;
        private readonly MensagemService _mensagemService;
        public ObterMensagemUseCase(IMensagemRepository mensagemRepository, MensagemService mensagemService)
        {
            _mensagemRepository = mensagemRepository;
            _mensagemService = mensagemService;
        }

        public string Executar()
        {
            Mensagem mensagem = _mensagemRepository.GetMensagem();
            return _mensagemService.FormatarMensagem(mensagem);
        }
    }
}