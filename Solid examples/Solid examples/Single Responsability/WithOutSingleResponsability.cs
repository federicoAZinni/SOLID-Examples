using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_examples.Single_Responsability
{
    class WithOutSingleResponsability
    {
    }

    // Without Single Responsability - In this case if i want to add a new function/responsability i need to modify my class beer

    public class Beer
    {
       public string name;
       public string brand;

       public Beer(string name, string brand)
       {
           this.name = name;
           this.brand = brand;
       }

       public void Save ()
       {
           Console.WriteLine($"Guardamos {this.name} y {this.brand}");
       }
       public void Enviar()
       {
           Console.WriteLine($"Enviamos {this.name} y {this.brand}");
       }
    }

}
