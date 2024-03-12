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
            int[] data = new int[] { 1, 5, 3, 2, 4 };
            Array array = new Array(data);

            int valueToCompare = 3;

            int lessCount = array.Less(valueToCompare);
            int greaterCount = array.Greater(valueToCompare);

            Console.WriteLine($"Кількість менших значень: {lessCount}");
            Console.WriteLine($"Кількість більших значень: {greaterCount}");
        }
    }

}
