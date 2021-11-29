using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            double num = 10.4;
            decimal num2 = 10;
            char character = 'A';
            bool condition = false;
            byte num3 = 255;
            short num4 = 32767;
            int num5 = 2147483647;
            long num6 = 9223372036854775807;
            //Console.WriteLine();
            //{0} mean index after comm ,
            Console.WriteLine("Num is (double){0}", num);
            Console.WriteLine("Num 2 is (decimal){0}", num2);
            Console.WriteLine("Num 3 is (byte){0}", num3);
            Console.WriteLine("Num 4 is (short){0}", num4);
            Console.WriteLine("Num 5 is (int){0}", num5);
            Console.WriteLine("Num 6 is (long){0}", num6);
            Console.WriteLine("Char is {0}", (int)character);
            Console.WriteLine("Char is {0}", condition);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Friday, Saturday, Sunday
    }
}
