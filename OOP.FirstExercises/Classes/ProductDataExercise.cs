using System;
using System.Collections.Generic;
using System.Globalization;
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

        public double TotalValueInStorage()
        {
            return Price * Quantity;
        }
        public void AddProductToStorage(int addedQuantity)
        {
            Quantity += addedQuantity;
        }
        public void RemoveProductFromStorage(int removedQuantity)
        {
            Quantity -= removedQuantity;
        }
        public override string ToString()
        {
            return 
                "Name: " 
                + Name 
                + ", Price: $" 
                + Price.ToString("F2", CultureInfo.InvariantCulture) 
                + ", Quantity: " 
                + Quantity 
                + ", Total: " 
                + TotalValueInStorage().ToString("F2", CultureInfo.InvariantCulture); 
        }

    }
}
