using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateOnly DataDeNascimento { get; private set; }
        public string? Email { get; set; }
        public List<Emprestimo> Emprestimos { get; set; } = new();

        public Pessoa(string nome, string sobrenome, DateOnly dataDeNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataDeNascimento = dataDeNascimento;
        }

        public Pessoa(string nome, string sobrenome, DateOnly dataDeNascimento, string email) :
            this(nome, sobrenome, dataDeNascimento)
        {
            Email = email;
        }

        public void AdicionarEmprestimo(Emprestimo emprestimo)
        {
            Emprestimos.Add(emprestimo);
        }

        public bool MultaPendente()
        {
            return Emprestimos.Any(e => e.Multa.valorPendente == true);
           
        }
    }
}
