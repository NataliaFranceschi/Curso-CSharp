using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Emprestimo
    {
        public DateTime DataEmprestimo { get; set; } = DateTime.Now;
        public DateTime PrazoParaDevolucao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public ItemBiblioteca ItemBiblioteca { get; set; }
        public Usuario Usuario { get; set; }

        public Emprestimo(ItemBiblioteca itemBiblioteca, Usuario usuario)
        {
            ItemBiblioteca = itemBiblioteca;
            Usuario = usuario;
        }
    }
}
