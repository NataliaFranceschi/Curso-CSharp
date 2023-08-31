using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Empresa
    {
        protected string NomeFantasia { get; set; }
        protected string RazaoSocial { get; set; }
        protected string CNPJ { get; set; }
        protected Tipo Tipo { get; set; }

        public Empresa(string nomeFantasia, string razaoSocial, string cNPJ, Tipo tipo)
        {
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            Tipo = tipo;
        }
    }
}
