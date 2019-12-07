using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Array
    {
        private int [] _array;
        public Array()
        {
            _array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        }
        public void PrintArray()
        {
            foreach(int el in _array)
            {
                Console.Write(el + " ");
            }

        }
        public void MaxArray()
        {
            int MaX=0;
            foreach (int el in _array)
            {
                if (MaX < el)
                    MaX = el;
            }
            Console.Write(MaX);
        }
        public void MinArray()
        {
            int MiN = 100000;
            foreach (int el in _array)
            {
                if (MiN > el)
                    MiN = el;
            } }
            public void CrArray()
            {
                int cr = 0;
                foreach(int el in _array)
                {
                    cr += el;
                }
            int len = _array.Length;
            cr /= len;
            Console.Write(cr);
            }
        
    }
}
