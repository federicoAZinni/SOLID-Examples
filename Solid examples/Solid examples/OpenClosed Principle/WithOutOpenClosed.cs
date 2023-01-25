using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_examples.OpenClosed_Principle
{
    class WithOutOpenClosed
    {
    }

   // Without Open/Closed principle
    public class Drink
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }

    public class Envoice
    {
        public decimal GetTotal(IEnumerable<Drink> lastDrink)
        {
            decimal total = 0;
            foreach (var drink in lastDrink)
            {
                if (drink.Type == "Agua")
                {
                    total += drink.Price;
                }
                else if (drink.Type == "Azucar")
                {
                    total += drink.Price * 3.33m;
                }
                else if (drink.Type == "Alcohol")
                {
                    total += drink.Price * 14.3m;
                }
            }
            return total;
        }
    }
}
