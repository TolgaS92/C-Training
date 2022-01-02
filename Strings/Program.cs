using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string city = "Denver";
            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);
            //}
            //string city2 = "Maimi";
            //Console.WriteLine(String.Format("{0} {1}", city, city2));
            string sentence = "My name is Tolga";
            var result = sentence.Length;
            bool result2 = sentence.EndsWith("a");
            bool result3 = sentence.StartsWith("M");
            // var result4 = sentence.indexOf("name");
            // var result5 = sentence.Substring();
            // var result6 = sentence.toLower();
            // var result7 = sentence.ToUpper();
            // var result8 = sentence.Replace("", "");
            // var result9 = sentence.Remove(2,4);
            var result10 = sentence.Insert(0, "Hello, ");
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result10);
            Console.ReadLine();
        }
    }
}
