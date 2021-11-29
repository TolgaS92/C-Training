using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(20, 30);
            int num1 = 20;
            int num2 = 30;
            var result2 = Add3(ref num1, num2);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(Multiply(5, 6));
            Console.WriteLine(Multiply2(2, 4, 5, 6, 8, 9));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int num1, int num2)
        {
            var result = num1 + num2;
            return result;
        }
        static int Add3(ref int num1, int num2)
        {
            num1 = 30;
            return num1 + num2;
        }
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Multiply2(params int[] nums)
        {
            // return num1 + num2 + num3 + ...
            return nums.Sum();
        }
    }
}
