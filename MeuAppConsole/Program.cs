using System;

namespace MeuAppConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());


        }

    }

}
