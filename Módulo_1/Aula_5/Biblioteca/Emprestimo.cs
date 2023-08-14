using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Emprestimo
    {
        public DateTime DataEmprestimo { get; private set; } = DateTime.Now;
        public DateTime PrazoDevolucao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Livro Livro { get; set; } 
        public Pessoa Pessoa { get; set; }
        public Multa Multa { get; set; } = new();

        public Emprestimo(Livro livro, Pessoa pessoa)
        {
            if (!livro.Disponivel)
            {
                Console.WriteLine("Este livro já esta emprestado.");
                return;
            }
            if (pessoa.MultaPendente())
            {
                Console.WriteLine($"{pessoa.Nome} está com multa pendente. É necessário a realização do pagamento para fazer outro empréstimo.");
            }
            Livro = livro;
            Pessoa = pessoa;
            PrazoDevolucao = DataEmprestimo.AddDays(7);
            livro.Disponivel = false;
        }

        public void Devolver()
        {
            DataDevolucao = DateTime.Now;
            Livro.Disponivel = true;

            if (DataDevolucao.Day > PrazoDevolucao.Day)
            {
                int diasAtraso = (DataDevolucao.Day - PrazoDevolucao.Day);
                Multa.CalcularMulta(diasAtraso);
                Console.WriteLine($"Livro entregue com atraso. Valor da multa: R$ {Multa.valorMulta}.");
                
            }
        }
    }
}
