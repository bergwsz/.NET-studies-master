using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.FirstExercises.Classes
{
    internal class ProductDataExercise
    {
        public string Name;
        public double Price;
        public int Quantity;


        public void Menu()
        {

        }
        public double StorageTotalValue(int quantity, double price)
        { 
            double total = quantity * price;
            return total;
        }
        public int AddProduct(int quantity)
        {
            Console.WriteLine("How much do you want to add?");
            int quantityAdded = int
                .Parse(Console.ReadLine());
            return quantity + quantityAdded;

        }
        public int RemoveProduct(int quantity)
        {
            Console.WriteLine("How much do you want to remove?");
            int quantityRemoved = int
                .Parse(Console.ReadLine());
            return quantity - quantityRemoved;
        }
        public bool Leave()
        {
            return false;
        }
    }
}
