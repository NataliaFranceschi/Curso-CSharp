using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Empreiteira : Empresa, IEmpresa
    {
        public Empreiteira(string nomeFantasia, string razaoSocial, string cNPJ, Tipo tipo)
                     : base(nomeFantasia, razaoSocial, cNPJ, tipo) { }

        public void RealizarVenda()
        {
            Console.WriteLine("Venda de serviço realizada!");
        }

    }
}
