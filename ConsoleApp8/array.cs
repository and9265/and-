using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Array
    {
        private int[] _array;
        //private int[] _array2;
        private bool ProverkaIndex(int a)
        {
            if (a >= 0 && a <= LenghtArray)
                return true;
            else
                return false;
        }
        public Array()
        {
            _array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        }
        public Array(int[] array)
        {
            _array = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                _array[i] = array[i];
        }
        public Array(Array array)
        {
            Array _array = array;
        }
        public int LenghtArray

        {
            get
            {
                int l = 1;
                foreach (var el in _array)
                {

                    l++;
                }
                return l;
            }
            set { }
        }
        public void PrintArray()
        {
            foreach (int el in _array)
            {
                Console.Write(el + " ");
            }

        }
        public int MaxArray()
        {
            int MaX = _array[0];
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
            int sum = 0;
            foreach (int el in _array)
            {
                sum += el;
            }
            return sum;
        }
        public long ProisArray()
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
        {if (ProverkaIndex(a) == true)
            {
                int la = LenghtArray + 1;
                int[] buffer = new int[la];
                for (int i = 0; i < la - 1; i++)
                    buffer[i] = _array[i];
                buffer[la - 1] = a;
                _array = new int[la];
                for (int i = 0; i < la; i++)
                    _array[i] = buffer[i];
            }
        }
        public void DelArrayByIndex(int number)
        {
            
            int[] buffer = new int[LenghtArray - 1];
            int k = 0;
            bool ka = true;
            for (int i = 0; i < LenghtArray; i++)
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
            _array = new int[LenghtArray - 1];

            for (int i = 0; i < LenghtArray - 1; i++)
                _array[i] = buffer[i];

        }
        public void DelArrayByNumber(int number)
        {
            
            int k = 0;
            int b = 0;
            
            foreach (var el in _array)
            {
                if (el == number)
                    k++;
            }
            int u = LenghtArray;
            int y = LenghtArray - k;
            int[] buffer = new int[y];
            for(int i=0;i<u;i++)
            {
                if (_array[i] == number)
                    b++;
                buffer[i-b] = _array[i];
            }
            _array = new int[y];
            for(int i=0;i<y;i++)
            {
                _array[i] = buffer[i];
            }
        }
        public int FindArrayIndex(int number)
        {
            int b = -1;
            for (int i = 0; i < LenghtArray; i++)
            {
                if (_array[i] == number)
                    b = i;
            }
            return b;

        }
        public void SortArrayPusir(bool vozrast = true)
        {
            if (vozrast == true)
            {
                for (int i = 0; i < LenghtArray; i++)
                {
                    for (int j = 0; j < LenghtArray - 1 - i; j++)
                    {
                        if (_array[j] > _array[j + 1])
                        {
                            int buf = _array[j];
                            _array[j] = _array[j + 1];
                            _array[j + 1] = buf;
                        }
                    }

                }
            }
            else
            {
                for (int i = 0; i < LenghtArray; i++)
                {
                    for (int j = 0; j < LenghtArray - 1 - i; j++)
                    {
                        if (_array[j] < _array[j + 1])
                        {
                            int buf = _array[j];
                            _array[j] = _array[j + 1];
                            _array[j + 1] = buf;
                        }
                    }

                }
            }

        }
        public void SortArrayVstavka()
        {
            int x;
            long i, j;
            int b = _array[0];
            _array[0] = MinArray();
            for (i = 1; i < LenghtArray; i++)
            {
                x = _array[i];

                for (j = i - 1; _array[j] > x; j--)
                    _array[j + 1] = _array[j];

                _array[j + 1] = x;
            }

            for (j = 1; j < LenghtArray && _array[j] < b; j++)
                _array[j - 1] = _array[j];
             _array[j - 1] = b;
        }
        public void SortArrayVibor()
        {
            int min; int t;
            for (int i = 0; i < LenghtArray - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < LenghtArray; j++)
                {
                    if (_array[j] < _array[min])
                        min = j;
                }
                t = _array[i];
                _array[i] = _array[min];
                _array[min] = t;
            }
        }
        public int ReturnNumberArray(int index)
        {
            return _array[index];
        }
        public void NewNumberArray(int index,int number)
        {
            for(int i=0;i<LenghtArray;i++)
            {
                if (i == index)
                    _array[i] = number;
            }
        }
        public int ChetArrayNumber(bool poloj=true)
        {
            int n=0;
            if (poloj == true)
            {
                foreach (var el in _array)
                {
                    if (el > 0)
                        n++;
                }
            }
            else
            {
                foreach (var el in _array)
                {
                    if (el < 0)
                        n++;
                }
            }
            return n;
        }
        public int KolvoNumberArray(int number)
        {
            int n = 0;
            foreach(var el in _array)
            {
                if (el == number)
                    n++;
            }
            return n;
        }
        public int ChetNechetArray(bool chet=true)
        {
            int n = 0;
            if(chet==true)
            {
                foreach (var el in _array)
                {
                    if (el %2== 0)
                        n++;
                }
            }
            else
            {
                foreach (var el in _array)
                {
                    if (el %2!= 0)
                        n++;
                }
            }
            return n;
        }
        public bool ProverkaSortVozrastArray(bool vaozrast=true)
        {
            if(vaozrast==true)
            {
                for (int i = 0; i < LenghtArray - 1; i++)
                {
                    if (_array[i] > _array[i + 1])
                        return false;

                }
                return true;
            }
            else
            {
                for (int i = 0; i < LenghtArray - 1; i++)
                {
                    if (_array[i] < _array[i + 1])
                        return false;

                }
                return true;
            }
        }






    }
}