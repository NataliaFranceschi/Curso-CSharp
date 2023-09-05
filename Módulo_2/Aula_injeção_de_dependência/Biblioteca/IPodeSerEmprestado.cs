using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal interface IPodeSerEmprestado
    {
        bool Disponivel { get; set; }
        void Emprestar(Emprestimo emprestimo);
        void Devolver(Emprestimo emprestimo);
    }
}
