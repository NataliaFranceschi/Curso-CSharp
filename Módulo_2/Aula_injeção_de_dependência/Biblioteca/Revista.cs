using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Revista : ItemBiblioteca
    {
        public int MesPublicacao { get; set; }

        public Revista(string titulo, int anoDePublicacao, int numeroDePaginas, int mesPublicacao) 
            : base(titulo, anoDePublicacao, numeroDePaginas)
        {
            MesPublicacao = mesPublicacao;
        }
    }
}
