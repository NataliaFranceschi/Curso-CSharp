using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Varejo : Empresa, IEmpresa
    {
        public Varejo(string nomeFantasia, string razaoSocial, string cNPJ, Tipo tipo)
                     : base(nomeFantasia, razaoSocial, cNPJ, tipo) { }

        public void RealizarVenda()
        {
            Console.WriteLine("Venda do produto realizada!");
        }
    }
}
