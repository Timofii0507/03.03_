using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03_
{
    public class Array : ICalc
    {
        private int[] _data;

        public Array(int[] data)
        {
            _data = data;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int value in _data)
            {
                if (value < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int value in _data)
            {
                if (value > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }

}
