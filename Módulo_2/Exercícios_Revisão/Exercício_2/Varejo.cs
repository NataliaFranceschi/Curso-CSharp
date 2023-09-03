using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Varejo : Empresa, IEmpresa
    {
        public EnviarNotificacaoWhatsApp EnviarNotificacaoWhatsApp { get; private set; }
        public Varejo(string nomeFantasia, string razaoSocial, string cNPJ, Tipo tipo, EnviarNotificacaoWhatsApp notificacao)
                     : base(nomeFantasia, razaoSocial, cNPJ, tipo) 
        {
            EnviarNotificacaoWhatsApp = notificacao;
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Venda do produto realizada!");
            EnviarNotificacaoWhatsApp.EnviarMensagemCliente();
        }
    }
}
