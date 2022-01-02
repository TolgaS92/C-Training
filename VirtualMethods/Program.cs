using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sqlserver sqlServer = new Sqlserver();
            sqlServer.Add();
            MySqlserver mySql = new MySqlserver();
            mySql.Add();

            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by Default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by Default");
        }
    }
    class Sqlserver : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by SQL Code");
            //base.Add();
        }
    }
    class MySqlserver : Database
    {

    }
}
