using System;

namespace Program
{
    class Recursion
    {

        public static int factorial(int n)
        {
            if (n <=1)
            {
                return 1;
            }

            return n * factorial(n - 1);
        }


        public static int sum(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n + sum(n - 1);
        }



        public static int reverse(int n)
        {

            int a = n / 10; // 5  // /  will give you qoutent

            int b = n % 10; // 4  // % will give you remainder

            Console.WriteLine("A  "+a + "    B "+b);


            return 0;

        }

        public static void Pirnt()
        {
            Console.WriteLine("Enter the number..");

            int input = Convert.ToInt32(Console.ReadLine());

            int result = reverse(input);

            Console.WriteLine(result);

            Console.Read();  
        }
    }
}
