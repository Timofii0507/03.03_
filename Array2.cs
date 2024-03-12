using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03_
{
    public class Array2 : IOutput2
    {
        private int[] _data;

        public Array2(int[] data)
        {
            _data = data;
        }

        public void ShowEven()
        {
            Console.WriteLine("Парні значення:");
            foreach (int value in _data)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(value);
                }
            }
        }

        public void ShowOdd()
        {
            Console.WriteLine("Непарні значення:");
            foreach (int value in _data)
            {
                if (value % 2 != 0)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}
