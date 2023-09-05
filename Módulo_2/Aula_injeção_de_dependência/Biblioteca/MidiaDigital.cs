using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class MidiaDigital : ItemBiblioteca, IPodeSerEmprestado
    {
        public bool Disponivel { get ; set; } = true;
        public string Autor { get; set; }
        public MidiaDigital(string titulo, int anoDePublicacao, int numeroDePaginas, string autor) 
            : base(titulo, anoDePublicacao, numeroDePaginas)
        {
            Autor = autor;
        }

        public void Emprestar(Emprestimo emprestimo)
        {
            Console.WriteLine("Empréstimo realizado com sucesso!");
        }

        public void Devolver(Emprestimo emprestimo)
        {
            emprestimo.DataDevolucao = DateTime.Now;
            Console.WriteLine("Devolução realizada com sucesso!");
        }

    }
}
