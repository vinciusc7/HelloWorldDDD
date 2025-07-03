using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itau.Uv8.Worker.Monitoracao.Domain.Entities;
using Itau.Uv8.Worker.Monitoracao.Domain.Interfaces;

namespace Itau.Uv8.Worker.Monitoracao.Infrastructure.Repositories
{
    public class MensagemRepository : IMensagemRepository
    {
        public Mensagem GetMensagem()
        {
            return new Mensagem
            {
                Message = "Hello world Vini"
            };
        }
    }
}