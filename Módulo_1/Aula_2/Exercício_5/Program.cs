/*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.
Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool
2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser
solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o
número 4. Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram
cada tipo de combustível, conforme exemplo*/

using System;

namespace Exercício5
{
    class Program
    {
        static void Main(string[] args)
        {
            int ethanol = 0;
            int gasoline = 0;
            int diesel = 0;
            bool fueling = true;

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1.Álcool");
                Console.WriteLine("2.Gasolina");
                Console.WriteLine("3.Diesel");
                Console.WriteLine("4.Fim");

            while (fueling) {

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ethanol += 1;
                        break;
                    case "2":
                        gasoline += 1;
                        break;
                    case "3":
                        diesel += 1;
                        break;
                    case "4":
                        fueling = false;
                        break;  
                    default:
                        Console.WriteLine("O valor inserido deve ser um número de 1 a 4.");
                        break;
                }
            }

                Console.WriteLine("MUITO OBRIGADO!");
                Console.WriteLine($"Álcool: {ethanol}");
                Console.WriteLine($"Gasolina: {gasoline}");
                Console.WriteLine($"Diesel: {diesel}");
                Console.ReadKey();
        }
    }
}