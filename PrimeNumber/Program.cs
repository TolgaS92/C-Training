﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(isPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();
        }
        private static bool isPrimeNumber(int number)
        {
            bool result = true;
            for(int i = 2; i < number -1; i++)
            {
                if(number%i== 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
    }
}
