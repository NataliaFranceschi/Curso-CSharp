using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    public class Produto
    {
        string Nome = "";
        double Preco = 0;
        int Quantidade = 0;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int _quantidade)
        {
            Quantidade += _quantidade;
        }

        public void RemoverProdutos(int _quantidade)
        {
            if (_quantidade > Quantidade)
            {
                Console.WriteLine("Quantidade em estoque não é suficiente");
            } else
            {
                Quantidade -= _quantidade;
            }
        }

    }
}
