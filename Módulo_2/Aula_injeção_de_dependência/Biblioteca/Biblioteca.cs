using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Biblioteca
    {
        public List<ItemBiblioteca> Colecao { get; set; } = new List<ItemBiblioteca>();
        public List<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        
        public void AdicionarItem(ItemBiblioteca item)
        {
            Colecao.Add(item);
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public void AdicionarEmprestimo(Emprestimo emprestimo)
        {
            Emprestimos.Add(emprestimo);
        }

        public bool ChecarPodeSerEmprestado(Emprestimo emprestimo)
        {
            if (emprestimo.ItemBiblioteca is IPodeSerEmprestado)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Este item não pode ser emprestado.");
                return false;
            }
        }

        public bool ChecarDisponibilidade(Emprestimo emprestimo)
        {
            if (((IPodeSerEmprestado)emprestimo.ItemBiblioteca).Disponivel)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"{emprestimo.ItemBiblioteca.Titulo} já está emprestado");
                return false;
            }
        }

        public void EmprestarItem(Emprestimo emprestimo)
        {
            if (ChecarPodeSerEmprestado(emprestimo) && ChecarDisponibilidade(emprestimo))
            {
                AdicionarEmprestimo(emprestimo);
                ((IPodeSerEmprestado)emprestimo.ItemBiblioteca).Emprestar(emprestimo);
            }
        }

        public Emprestimo? BuscarEmprestimo(ItemBiblioteca item, Usuario usuario)
        {
            return Emprestimos.FirstOrDefault(i => i.ItemBiblioteca == item
                                                    && i.Usuario == usuario);
        }

        public void DevolverItem(ItemBiblioteca item, Usuario usuario)
        {
            var emprestimo = BuscarEmprestimo(item, usuario);
            if (emprestimo != null)
            {
                ((IPodeSerEmprestado)emprestimo.ItemBiblioteca).Devolver(emprestimo); 
            } else
            {
                Console.WriteLine("Não foi possível realizar a devolução. Informações incorretas.");
            }
        }


    }
}
