/*Escrever um programa que preencha um vetor de 100 elementos com valores inteiros aleatórios, e
identifique o maior e o menor número gerados, e respectivas posições.*/

using System;

namespace Exercício4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            var random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next();
            }

            int highestNumber = numbers.Max();
            int lowestNumeber = numbers.Min();

            Console.WriteLine($"O maior número é {highestNumber} que está na posição {Array.IndexOf(numbers, highestNumber)}. ");
            Console.WriteLine($"O menor número é {lowestNumeber} que está na posição {Array.IndexOf(numbers, lowestNumeber)}. ");
            Console.ReadKey();
        }
    }
}