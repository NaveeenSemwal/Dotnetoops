using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    
        /// <summary>
        /// This is example of abstract class
        /// </summary>
        abstract class Parent
        {
            public void Display()
            {
                Console.WriteLine("Hi This is naveen");
            }

            // Note : virtual or abstract function cannot be private
            public abstract void PrintName();
        }

        class Child : Parent
        {
            const int age = 25;

            readonly string name = "naveen";

            public Child()
            {
                name = "semwal";
            }

            public override void PrintName()
            {
                Console.WriteLine("This is overriddin function");
            }
        }
    

    class Run2
    {
        public static void Execute()
        {
            Parent parent = new Child();
            parent.PrintName();
        }
    }
}
