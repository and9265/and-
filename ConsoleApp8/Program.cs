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
            int[] arra3 = new int[5]{0,1,2,3,4};

            Array arr = new Array(arra3);
            arr.AddArray(5);
            arr.PrintArray();
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");

           Console.ReadKey();

        }
    }
}
