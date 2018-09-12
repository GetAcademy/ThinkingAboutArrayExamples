using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEksempel1
{
    class Program
    {
        static void Main(string[] args)
        {
            Search2(args);
        }

        static void Search2(string[] args)
        {
            int[] intArray = { 10, 20, 30 };
            int targetValue = Convert.ToInt32(args[0]);
            int targetPos = 0;
            while (targetPos < intArray.Length
                && intArray[targetPos] != targetValue)
            {
                targetPos++;
            }

            var isFound = targetPos < intArray.Length;
            var text = isFound
                ? $"Fant verdien {targetValue} i indeks {targetPos}."
                : $"Fant ikke verdien {targetValue}.";
            Console.WriteLine(text);
        }

        static void Search(string[] args)
        {
            int[] intArray = { 10, 20, 30 };
            int targetValue = Convert.ToInt32(args[0]);
            int targetPos = 0;
            while (targetPos < intArray.Length
                && intArray[targetPos] != targetValue)
            {
                targetPos++;
            }

            var isFound = targetPos < intArray.Length;
            var text = isFound
                ? $"Fant verdien {targetValue} i indeks {targetPos}."
                : $"Fant ikke verdien {targetValue}.";
            Console.WriteLine(text);
        }
    }
}
