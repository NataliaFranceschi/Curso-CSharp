namespace Exercício_1
{
    public class Produto
    {
        public string Nome = "";
        public double Preco = 0;
        public int Quantidade = 0;

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
                Console.WriteLine("Quantidade em estoque não é suficiente.");
            } else
            {
                Quantidade -= _quantidade;
            }
        }

        public void RelatorioProduto()
        {
            Console.WriteLine("Dados produto:");
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Quantidade: {Quantidade}");
            Console.WriteLine($"Valor total em estoque: {ValorTotalEmEstoque()}");
        }
    }
}
