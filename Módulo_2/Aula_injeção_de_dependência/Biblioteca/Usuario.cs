using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Usuario
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public DateOnly DataNascimento { get; set; }

        public Usuario(string name, string cPF, string celular, string email, DateOnly dataNascimento)
        {
            Name = name;
            CPF = cPF;
            Celular = celular;
            Email = email;
            DataNascimento = dataNascimento;
        }
    }
}
