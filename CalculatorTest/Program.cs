using System;

namespace CalculatorTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        { 
            Console.WriteLine("Escolha que operação você deseja fazer");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("-------------------------------------------------------------------------");

            short operation = short.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Soma();
                    Console.Clear();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    Menu();
                    break;
            }

        }

        static void Soma()
        { 
            Console.WriteLine("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            var sum = n1 + n2;
            Console.WriteLine($"Resultado da soma: {sum}");
        }
        static void Subtracao()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            var sum = n1 - n2;
            Console.WriteLine($"Resultado da subtracao: {sum}");
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            var sum = n1 * n2;
            Console.WriteLine($"Resultado da multiplicacao: {sum}");
        }
        static void Divisao()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            var sum = n1 / n2;
            Console.WriteLine($"Resultado da divisao: {sum}");
        }
    }
}
