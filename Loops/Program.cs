using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //forLoop();
            //whileLoop();
            //DoWhile();
            ForEach();
        }

        private static void ForEach()
        {
            string[] students = new string[3] { "Tolga", "Dani", "Murph" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();
        }

        private static void DoWhile()
        {
            int num = 10;
            do
            {
                Console.WriteLine(num);
                num--;

            } while (num >= 11);
            Console.ReadLine();
        }

        private static void whileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Finished");
            Console.ReadLine();
        }

        private static void forLoop()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
