using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Varejo : Empresa
    {
        public Varejo(string nomeFantasia, string razaoSocial, string cNPJ, Tipo tipo) 
                     : base(nomeFantasia, razaoSocial, cNPJ, tipo) { }

        public override void RealizarVenda()
        {
            Console.WriteLine("Venda do produto realizada!");
        }
    }
}
