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
            //args = new[] {"10", "11", "12"};
            FindMax(args);
            //Search(args);
        }

        static void FindMax(string[] args)
        {
            int[] intArray = args.Select(s => Convert.ToInt32(s)).ToArray();
            var maxSoFar = intArray[0];
            var maxSoFarIndex = 0;
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxSoFar)
                {
                    maxSoFar = intArray[i];
                    maxSoFarIndex = i;
                }
            }

            Console.WriteLine($"Det høyeste tallet er {maxSoFar} og ligger i indeks {maxSoFarIndex}.");
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
