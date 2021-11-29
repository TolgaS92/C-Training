using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string student = "Tolga";
            //string[] students2 = { "Xeidoss", "IIR8", "IIR6" };
            //string[] students = new string[3];
            //students[0] = "Tolga";
            //students[1] = "Murphy";
            //students[2] = "Dani";
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student); 
            //}
            //Console.WriteLine("******");
            //foreach (var stdu in students2)
            //{
            //    Console.WriteLine(stdu);
            //}
            string[,] regions = new string[5, 3]
            {
                { "Istanbul", "Tekirdag", "Bursa"},
                { "Ankara", "Nevsehir", "Cankiri"},
                { "Izmir", "Manisa", "Canakkale"},
                { "Ordu", "Trabzon", "Rize"},
                { "Sinop", "Duzce", "Zonguldak"},

            };
            for ( int i = 0; i <= regions.GetUpperBound(0); i++ )
            {
                for(int j=0; j<=regions.GetUpperBound(1); j++ )
                {
                    Console.WriteLine(regions[i , j]);
                }
                Console.WriteLine("******");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
