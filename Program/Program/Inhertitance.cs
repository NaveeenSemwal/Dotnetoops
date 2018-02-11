using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Inhertitance
    {
        public void PrintName()
        {
            Console.WriteLine("This is parent class PrintName");
        }
    }

    class Derived : Inhertitance
    {
        public new void PrintName()
        {
            Console.WriteLine("This is chiild class PrintName");
        }
    }


    class A : Derived
    {
        public new void PrintName()
        {
            Console.WriteLine("This is A class PrintName");
        }
    }


    class Run1
    {
        public static void Execute()
        {
            //Result : In this case of inheritance parent's class function will be called.
            Inhertitance inhertitance = new Derived();
            inhertitance.PrintName();

            //Result : In this case of inheritance Derived's class function will be called.
            Derived derived = new A();
            derived.PrintName();
        }
    }
}
