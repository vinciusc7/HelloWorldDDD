using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itau.Uv8.Worker.Monitoracao.Domain.Entities;

namespace Itau.Uv8.Worker.Monitoracao.Domain.Interfaces
{
    public interface IMensagemRepository
    {
        Mensagem GetMensagem();
    }
}