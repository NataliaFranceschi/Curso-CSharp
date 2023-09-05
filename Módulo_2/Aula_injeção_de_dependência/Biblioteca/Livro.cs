using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Livro : ItemBiblioteca, IPodeSerEmprestado
    {
        public string Autor { get; set; }
        public bool Disponivel { get; set; } = true;
        public Livro(string titulo, int anoDePublicacao, int numeroDePaginas, string autor) 
            : base(titulo, anoDePublicacao, numeroDePaginas)
        {
            Autor = autor;
        }

        public void Emprestar(Emprestimo emprestimo)
        {
            emprestimo.PrazoParaDevolucao = emprestimo.DataEmprestimo.AddDays(14);
            Disponivel = false;
            Console.WriteLine("Empréstimo realizado com sucesso!");
        }

        public void Devolver(Emprestimo emprestimo)
        {
            emprestimo.DataDevolucao = DateTime.Now;
            Disponivel = true;

            if (emprestimo.DataDevolucao.Day > emprestimo.PrazoParaDevolucao.Day)
            {
                int diasAtraso = (emprestimo.DataDevolucao.Day - emprestimo.PrazoParaDevolucao.Day);
                Console.WriteLine($"Livro entregue com {diasAtraso} dias de atraso.");

            }
            else
            {
                Console.WriteLine("Devolução realizada com sucesso!");
            }
        }

    }
}
