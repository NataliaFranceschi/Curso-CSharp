using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class EnviarNotificacaoWhatsApp : IEnviarNotificacao
    {
        public void EnviarMensagemCliente()
        {
            Console.WriteLine("Estou enviando uma mensagem no WhatsApp do Cliente");
        }
    }
}
