using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class ItemBiblioteca
    {
        public string id {  get; set; }
        public string Titulo { get; set; }
        public int AnoDePublicacao { get; set; }
        public int NumeroDePaginas { get; set; }

        public ItemBiblioteca(string titulo, int anoDePublicacao, int numeroDePaginas)
        {
            Titulo = titulo;
            AnoDePublicacao = anoDePublicacao;
            NumeroDePaginas = numeroDePaginas;
            id = GerarId();
        }

        public string GerarId()
        {
            Guid id = Guid.NewGuid();
            return id.ToString();
        }
    }
}
