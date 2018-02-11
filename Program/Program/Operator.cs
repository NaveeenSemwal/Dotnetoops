using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /// <summary>
    /// only pre increase variable value not post.
    /// 
    ///  https://www.sitesbay.com/cprogramming/c-increment-decrement-operator
    ///  
    ///  http://www.sanfoundry.com/online-c-test-increment-decrement-operators/
    ///  
    /// http://www.sanfoundry.com/c-plus-plus-quiz-increment-decrement/
    /// 
    /// </summary>
    class Operator
    {
        public static void PreIncrement()
        {
            int a = 10;

            // result = 23 :  11  + 12
            int result = ++a + ++a;

            Console.Write(result);

            Console.Read();
        }

        public static void PostIncrement()
        {
            int a = 10;

            // result = 21 :  11  + 10
            int result = a++ + a++;

            Console.Write(result);

            Console.Read();
        }


        public static void MixIncrement()
        {
            int a = 10;

            // result = 22 :  11  + 11
            //int result = ++a + a++;

            // 11 + 11 + 1 + 11  = 34   // In post last ++ is not counted
            // int result = ++a + a++ + a++;

            // 11 + 11 + 1 + 12 = 35   // In pre ++ will be counted
            //int result = ++a + a++ + ++a;


            // 11 + 11 + 1 = 23   + 11  = 24
            // int result = ++a + a++ + a;

            //  11 + 11+ 1 - 12+1
            //  int result = ++a + a++ -a++;



            //  PROBLEM

            //  11 + 11+ 1 - 13
            // int result = ++a + a++ - ++a;

            // Console.Write(a);

            // How result is coming 9 instead of 10

            //  Console.Write(result);



            //int c = 2, b;

            //// 2+1  + 3-1 + 3 + 2 = 10
            //b = c++ + c-- + ++c + --c;

            //Console.Write(b);


            // 10 + 11
            int RES = a++ + a++;

            Console.WriteLine(RES);

            Console.Read();
        }

        public static void MixIncrement1()
        {
            int x, a, b, c;
            a = 2;
            b = 4;
            c = 5;

            // 2 -1 + 4+ 1 - 6 = 0
            x = a-- + b++ - ++c;
            Console.Write(x);

            Console.Read();
        }
    }
}
