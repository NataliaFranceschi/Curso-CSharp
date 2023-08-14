using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Livro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public string? Editora { get; private set; }
        public bool Disponivel { get; set; } = true;

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public Livro(string titulo, string autor, string editora) :
            this(titulo, autor)
        {
            Editora = editora;
        }

    }
}
