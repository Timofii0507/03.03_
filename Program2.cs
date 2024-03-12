using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Array2 array = new Array2(data);

            array.ShowEven();
            Console.WriteLine();
            array.ShowOdd();
        }
    }

}
