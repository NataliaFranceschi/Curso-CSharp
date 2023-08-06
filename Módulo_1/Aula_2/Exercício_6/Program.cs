/*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo,
mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para
fora do intervalo). */

using System;

namespace Exercício6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int lengthLoop;
                int numbersInsideInterval = 0;

                Console.WriteLine("Escolha um número inteiro:");
                lengthLoop = int.Parse(Console.ReadLine());

                Console.WriteLine($"Insira {lengthLoop} números:");
                for (int i = 0; i < lengthLoop; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number >= 10 && number <= 20)
                    {
                        numbersInsideInterval++;
                    }
                }

                Console.WriteLine($"{numbersInsideInterval} in");
                Console.WriteLine($"{lengthLoop - numbersInsideInterval} out");
                Console.ReadKey();
            } catch
            {
                Console.WriteLine("O valor inserido deve ser um número inteiro.");
                Console.ReadKey();
            }
        }
    }
}