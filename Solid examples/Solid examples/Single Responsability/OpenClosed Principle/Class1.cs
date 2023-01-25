using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_examples.Single_Responsability.OpenClosed_Principle
{
    //Open for an extentions but closed to modifys

    //Without Open/Closed principle
    //public class Drink
    //{   
    //    public string Name { get; set; }
    //    public string Type { get; set; }
    //    public decimal Price { get; set; }
    //}

    //public class Envoice
    //{
    //    public decimal  GetTotal(IEnumerable<Drink> lastDrink)
    //    {
    //        decimal total = 0;
    //        foreach (var drink in lastDrink)
    //        {
    //            if(drink.Type == "Agua")
    //            {
    //                total += drink.Price;
    //            }else if (drink.Type=="Azucar")
    //            {
    //                total += drink.Price * 3.33m;
    //            }else if(drink.Type == "Alcohol")
    //            {
    //                total += drink.Price * 14.3m;
    //            }
    //        }
    //        return total;
    //    }
    //}



    // Open/Closed Principle - In this case, we transform a Drink class to an interface that allows us let the Idrink closed to modifys but open to add a extension
    // as in the class Alcohol with added a new variable "Promo" and a new logic for "GetPrice" function. 

    public interface IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal GetPrice();
    }

    public class Water : IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal Envoice { get; set; }

        public decimal GetPrice()
        {
            return Price * Envoice;
        }
    }

    public class Alcohol:IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal Promo { get; set; }
        public decimal GetPrice()
        {
            return Price * Promo;
        }
    }
}
