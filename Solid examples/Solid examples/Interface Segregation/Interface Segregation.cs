using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_examples.Interface_Segregation
{
    // Utilizar varias interfaces de ser necesario
    class Class1
    {
        public void Action()
        {

        }
    }

    //We can separte the interface to others to be mor especific about the methods they can do 

    public interface ILabor
    {
        public void Iniciar();
        public void Detener();
    }

    public interface ILaborPersona
    {
        public void Comer();
        public void IrAlBaño();
    }

    public class Trabajador : ILabor,ILaborPersona  //Now we can use 2 interface on this class.
    {
        public void Comer()
        {
            Console.WriteLine("comer");
        }

        public void Detener()
        {
            Console.WriteLine("Detener");
        }

        public void Iniciar()
        {
            Console.WriteLine("Iniciar");
        }

        public void IrAlBaño()
        {
            Console.WriteLine("IrAlBaño");
        }
    }

    public class Maquina : ILabor // and just one on this.
    {
        public void Detener()
        {
            Console.WriteLine("Detener");
        }

        public void Iniciar()
        {
            Console.WriteLine("Iniciar");
        }
    }
}
