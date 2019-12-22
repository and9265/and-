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
        private int[] _array2;
        public Array()
        {
            _array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        }
        public Array(int[] array,int lengt)
        {
            _array = new int[lengt];
            for (int i = 0; i < lengt; i++)
                _array[i] = array[i];
        }
        public Array(Array []array)
        {
            
           Array[] _array = new Array[LenghtArray()];
            for (int i = 0; i < LenghtArray(); i++)
                _array[i] = array[i];
                

        }
        public int LenghtArray()

        {
            int l=0;
            foreach(var el in _array)
            {
                
                    l++;
            }
            return l;
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
        public void AddArray(int a)
        {
            int la = LenghtArray()+1;
           int[] buffer = new int[la];
            for (int i = 0; i < la-1; i++)
                buffer[i] = _array[i];
            buffer[la-1] = a;
           _array = new int[la];
            for (int i = 0; i < la; i++)
                _array[i] = buffer[i];
            
        }
        public void DelArrayByIndex(int number)
        {
            int la = LenghtArray();
            int[] buffer = new int[la-1];
            int k=0;
            bool ka=true;
            for (int i = 0; i < la; i++)
            {
                if (ka == true)
                    k = i;
                else
                    k++;
                if (i != number)
                {
                    buffer[k] = _array[i];

                }
                else { k--; ka = false; }
            }
                _array = new int[la-1];
            
                for (int i = 0; i < la-1; i++)
                    _array[i] = buffer[i];
            
        }
        public void DelArrayByNumber(int number)
        {
            int[] buffer = new int[LenghtArray()];
            int k = 0;
            bool ja = true;
            int j=0;
            for (int i = 0; i < LenghtArray(); i++)
            {
                buffer[i] = _array[i];
                if (_array[i] == a)
                    k++;
            }
            _array = new int[LenghtArray() - k];
            for(int i=0;i<LenghtArray();i++)
            { if (ja == true)
                    j = k;
                else
                    j++;
                if (buffer[i] != a)
                { _array[j] = buffer[i]; }
                else { j--; ja = false; }

            }

        }
        public int FindArrayIndex(int number)
        {
            int b=-1;
            for(int i=0;i<LenghtArray();i++)
            {
                if (_array[i] == number)
                    b = i;
            }
            return b;
                
        }

    }
}
