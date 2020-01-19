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
            int[] arra3 = new int[15]{10,9,8,7,6,5,4,3,2,1,0,-1,12,-3,-4 }; 
            Array array2 = new Array(arra3);
            array.AddArray(11);
            array.PrintArray();
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");

           Console.ReadKey();

        }
    }
}
