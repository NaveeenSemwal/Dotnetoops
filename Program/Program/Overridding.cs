using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
   
        class ParentEducation
        {
            public virtual void Education()
            {
                Console.WriteLine("This is Parent Education");
            }
        }


        class ChildEducation : ParentEducation
        {
            public override void Education()
            {
                Console.WriteLine("This is Child Education");
            }
        }

    class Run3
    {
        public static void Execute()
        {
            ParentEducation parentEducation = new ChildEducation();

            parentEducation.Education();
        }
    }



}
