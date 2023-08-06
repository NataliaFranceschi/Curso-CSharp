/*- Um imposto é calculado com base na seguinte tabela:
Até 1.200,00 isento
de 1.201,00 a 2.500,00 10%
de 2.501,00 a 5.000,00 15%
acima de 5.000,00 20%.
Implemente um programa que leia o valor base e calcule o imposto a pagar*/

using System;

namespace Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu salário:");
            bool invalidSalary = true;
            double salary = 0;

            while (invalidSalary) {
                if (!double.TryParse(Console.ReadLine(), out salary)) {
                    Console.WriteLine("Entrada inválida.");
                } else {
                    invalidSalary = false;
                }
            }

            if (salary <= 1200) {
                Console.WriteLine("Isento de Imposto");
            } else if (salary <= 2500) {
                Console.WriteLine($"O valor do imposto a pagar é de R${Math.Round(salary * 0.1)}.");
            } else if (salary <= 5000) {
                Console.WriteLine($"O valor do imposto a pagar é de R${Math.Round(salary * 0.15)}.");
            } else {
                Console.WriteLine($"O valor do imposto a pagar é de R${Math.Round(salary * 0.2)}.");
            }

            Console.ReadKey();
        }
    }
}