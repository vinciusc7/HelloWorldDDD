using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itau.Uv8.Worker.Monitoracao.Domain.Entities;

namespace Itau.Uv8.Worker.Monitoracao.Services.Services
{
    public class MensagemService
    {
        public string FormatarMensagem(Mensagem mensagem)
        {
            if (string.IsNullOrEmpty(mensagem.Message))
            {
                return "mensagem vazia";
            }
            else
            {
                return $"Mensagem formatada: {mensagem.Message}";
            }
        }
    }
}