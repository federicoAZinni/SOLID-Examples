using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_examples.Liskov_Substition_Principle
{
    //Una clase hija debería poder ser utiliza como si fuese su clase padre (sustituir)
    class Class2
    {
        T t = new S1(); // se ve como la clase hija "S2" puede reemplazar a la clase padre "T"
        void Action ()
        {
            t.GetName(); 
            t = new S2();
        }
    }

    public abstract class T // se crea un calse abs de T para que no puede ser creada. 
    {
        public abstract string GetName();
    }

    public class S1 : T
    {
        public override string GetName()
        {
            return "S";
        }
    }
    public class S2 : T
    {
        public override string GetName()
        {
            return "S1";
        }
    }
}
