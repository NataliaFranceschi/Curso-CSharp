namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            try
            {
                Console.WriteLine("Insira o nome do produto:");
                produto.Nome = Console.ReadLine();
                Console.WriteLine("Insira o preço do produto:");
                produto.Preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira a quantidade do produto:");
                produto.Quantidade = int.Parse(Console.ReadLine());

                produto.RelatorioProduto();

                Console.WriteLine("Insira a quantidade de produto que deseja adicionar ao estoque:");
                int _quantidade = int.Parse(Console.ReadLine());
                produto.AdicionarProdutos(_quantidade);


                produto.RelatorioProduto();

                Console.WriteLine("Insira a quantidade de produto que deseja remover do estoque:");
                _quantidade = int.Parse(Console.ReadLine());
                produto.RemoverProdutos(_quantidade);


                produto.RelatorioProduto();

            } catch (Exception)
            {
                Console.WriteLine("O valor inserido está incorreto");
            }

        }
    }
}