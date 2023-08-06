/* A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais de 40
horas receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo de 50%. Escreva um
algoritmo que leia o número de horas trabalhadas em um mês, o salário por hora e escreva o salário total do
funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas (considere que o mês
possua 4 semanas exatas). */

using System;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoursWorked;
            double salaryPerHour;
            int minHoursPerMonth = 40 * 4;
            double addExtraHour = 0.5;
            double extraHour = 0;

            try
            {
                Console.WriteLine("Insira o número de horas trabalhada:");
                hoursWorked = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira o salário por hora trabalhada:");
                salaryPerHour = double.Parse(Console.ReadLine());

                if (hoursWorked > minHoursPerMonth)
                {
                    extraHour = hoursWorked - minHoursPerMonth;
                }

                double salary = Math.Round((hoursWorked * salaryPerHour) + (extraHour * (salaryPerHour * addExtraHour)));

                Console.WriteLine($"Seu salário esse mês foi de R${salary}.");
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
