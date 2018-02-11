using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class LargeNumber
    {
        /// <summary>
        /// Program to find the largerest number in array
        /// </summary>
        /// <param name="array"></param>
        public static void BiggerOne(int[] array)
        {
            int big = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    big = array[i];
                }
                else
                {
                    if (big < array[i])
                    {
                        big = array[i];
                    }
                }
            }

            Console.WriteLine("Larger one is :  "+ big);

            Console.Read();

        }
    }
}
