/*Faça um algoritmo para ler: quantidade atual em estoque, quantidade máxima em estoque e quantidade
mínima em estoque de um produto. Calcular e escrever a quantidade média ((quantidade média =
quantidade máxima + quantidade mínima)/ 2). Se a quantidade em estoque for maior ou igual a quantidade
média escrever a mensagem 'Não efetuar compra', senão escrever a mensagem 'Efetuar compra'.*/

using System;

namespace Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            double qntStock;
            double maxQntStock;
            double minQntStock;

            try
            {

                Console.WriteLine("Insira a quantidade atual em estoque:");
                qntStock = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a quantidade máxima do estoque:");
                maxQntStock = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a quantidade mínima do estoque:");
                minQntStock = int.Parse(Console.ReadLine());

                double averageStock = (maxQntStock + minQntStock) / 2;

                if (qntStock >= averageStock)
                {
                    Console.WriteLine("Não efetuar compra.");
                }
                else
                {
                    Console.WriteLine("Efetuar compra.");
                }

                Console.ReadKey();

            }
            catch
            {
                Console.WriteLine("O valor inserido deve ser um número.");
                Console.ReadKey();
            }
        }
    }
}