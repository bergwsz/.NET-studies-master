using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Selecione sua opção: ");
            short escolha = short.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Soma();
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

                case 5:
                    SairAplicacao();
                    break;

                default:
                    RetornoNumeroInvalido();
                    break;

            }
        }

        static void SairAplicacao()
        {
            Console.Clear();
            return;
        }

        static void RetornoNumeroInvalido()
        {
            Console.Clear();
            Console.WriteLine("Sua opção é invalida!");
            Console.WriteLine("Aperte uma tecla para continuar.");

            Console.ReadKey();
            Menu();
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            decimal primeiroValor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            decimal segundoValor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("");

            decimal resultado = primeiroValor + segundoValor;

            Console.WriteLine($"Resultado da soma dos números apresentados: {resultado}");

        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            decimal primeiroValor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            decimal segundoValor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("");
            decimal resultado = primeiroValor - segundoValor;
            Console.WriteLine($"Resultado da subtração dos números apresentados: {resultado}");
            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            decimal primeiroValor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            decimal segundoValor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("");
            decimal resultado = primeiroValor / segundoValor;
            Console.WriteLine($"Resultado da divisão dos números apresentados: {resultado}");
            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            decimal primeiroValor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            decimal segundoValor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("");
            decimal resultado = primeiroValor * segundoValor;
            Console.WriteLine($"Resultado da multiplicação dos números apresentados: {resultado}");
            Console.ReadKey();
        }
    }
}
