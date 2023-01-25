using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_examples.Interface_Segregation
{
    class WithOutInterfaceSegregation
    {
    }

    //in this case the inteface ILabor have the methods thats constitute the work on a factory.
    public interface ILabor1
    {
        public void Iniciar();
        public void Detener();
        public void Comer();
        public void IrAlBaño();
    }

    public class Trabajador1 : ILabor1  //In the class Trabajador we dont have problems all the methods are used 
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

    public class Maquina1 : ILabor1 // In this class we have a problem, becouse a machine dont need eat or go to the bathroom. 
    {
        public void Comer()
        {

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

        }
    }
}
