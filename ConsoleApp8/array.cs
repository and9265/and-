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
        public int MaxArray()
        {
            int MaX=_array[0];
            foreach (int el in _array)
            {
                if (MaX < el)
                    MaX = el;
            }
            return MaX;
        }
        public int MinArray()
        {
            int MiN = _array[0];
            foreach (int el in _array)
            {
                if (MiN > el)
                    MiN = el;
            }
            return MiN;
        }
        public int CrArray()
            {
                int cr = SumArray(); ;
            
            int len = _array.Length;
            cr /= len;
            return cr;
            }
        public int SumArray()
        {
            int sum=0;
            foreach(int el in _array)
            {
                sum += el;
            }
            return sum;
        }
        public long  ProisArray()
        {
            long pro = 1;
            foreach (int el in _array)
            {
                pro *= el;
            }
            return pro;
        }
        public bool FindArray(int a)
        {
            foreach (int el in _array)
                if (a == el)
                    return true;
            return false;
        }
    }
}
