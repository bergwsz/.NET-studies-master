using System;
using System.Globalization;
using OOP.FirstExercises.Classes;

namespace OOP.FirstExercises
{

    internal class Program
    {
        static void Main(string[] args)
        {
            ProductDataExercise();
        }

        static void OldestPerson()
        {
            OldPersonExercise A = new OldPersonExercise();
            OldPersonExercise B = new OldPersonExercise();

            Console.WriteLine("First person data: ");
            Console.Write("Name: ");
            A.Name = Console.ReadLine();
            Console.Write("Age: ");
            A.Age = int
                .Parse(Console.ReadLine());

            Console.WriteLine("Second person data: ");
            Console.Write("Name: ");
            B.Name = Console.ReadLine();
            Console.Write("Age: ");
            B.Age = int
                .Parse(Console.ReadLine());

            if (A.Age > B.Age)
                Console.WriteLine($"Oldest person: {A.Name}");
            else
                Console.WriteLine($"Oldest person: {B.Name}");
        }
        static void AverageSalary()
        {
            SalaryExercise A = new SalaryExercise();
            SalaryExercise B = new SalaryExercise();

            Console.WriteLine("First worker data: ");
            Console.Write("Name: ");
            A.Name = Console.ReadLine();
            Console.Write("Salary: ");
            A.Salary = double
                .Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Second worker data: ");
            Console.Write("Name: ");
            B.Name = Console.ReadLine();
            Console.Write("Salary: ");
            B.Salary = double
                .Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double average_salary = (A.Salary + B.Salary) / 2;
            Console.WriteLine($"Average salary between them: {average_salary.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        static void TriangleArea()
        {
            TriangleExercise X = new TriangleExercise();
            TriangleExercise Y = new TriangleExercise();

            Console.WriteLine("Input the first triangle especifications ");

            X.A = double
                .Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.B = double
                .Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.C = double
                .Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Input the second triangle especifications: ");

            Y.A = double
                .Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.B = double
                .Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.C = double
                .Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double area_x = X.Area();
            double area_y = Y.Area();


            Console.WriteLine($"First triangle area: {area_x.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Second triangle area: {area_y.ToString("F2", CultureInfo.InvariantCulture)}");

            if (area_x > area_y)
                Console.WriteLine($"Biggest area: {area_x.ToString("F2", CultureInfo.InvariantCulture)}");
            else
                Console.WriteLine($"Biggest area: {area_y.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        static void ProductDataExercise()
        {
            // EXEMPLO DE ALTERAÇÃO NO PROJETO

            ProductDataExercise p = new ProductDataExercise();

            Console.WriteLine("Input the product data: ");
            Console.WriteLine("");

            Console.Write("Name: ");
            p.Name = Console.ReadLine();
            Console.Write("Price: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity: ");
            p.Quantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{p}");

            Console.WriteLine("");
            Console.Write($"How many {p.Name.ToLower()}s do you want to add to the storage? ");
            int quantity = int.Parse(Console.ReadLine());
            p.AddProductToStorage(quantity);
            Console.WriteLine($"Updated data of product : {p}");

            Console.WriteLine("");
            Console.Write($"How many {p.Name.ToLower()}s do you want to remove from the storage? ");
            quantity = int.Parse(Console.ReadLine());
            p.RemoveProductFromStorage(quantity);
            Console.WriteLine($"Updated data of product : {p}");
        }
    }
}
