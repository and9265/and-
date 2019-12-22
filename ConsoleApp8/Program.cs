using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array();
           
            array.AddArray(11);
            array.PrintArray();
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            array.FindArrayIndex(3);
            Console.WriteLine(array.FindArrayIndex(11));
            Console.ReadKey();

        }
    }
}
