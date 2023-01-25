using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_examples
{
    class SingleResponsability
    {

    }
}

// Single Responsability - In this case if i want to add a new function/responsability i just need to create antoher class and take one variable of type Beer.
// like in this example, i separated the functions Save() and Enviar() and creater another class with this responsabilitys, another benefice its that i dont need to modify the big class "Beer".
public class Beer
    {
        public string name;
        public string brand;

        public Beer(string name, string brand)
        {
            this.name = name;
            this.brand = brand;
        }
    }

    public class BeerDB
    {
        private Beer beer;

        public BeerDB(Beer beer)
        {
            this.beer = beer;
        }

        public void Save()
        {
            Console.WriteLine($"Guardamos {beer.name} y {beer.brand}");
        }
    }

    public class BeerRequest
    {
        private Beer beer;

        public BeerRequest(Beer beer)
        {
            this.beer = beer;
        }

        public void Enviar()
        {
            Console.WriteLine($"Enviamos {beer.name} y {beer.brand}");
        }
    }

