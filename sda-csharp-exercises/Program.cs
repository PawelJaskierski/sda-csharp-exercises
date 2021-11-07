using System;
using System.Collections.Generic;
using System.Linq;
namespace sda_csharp_exercises
{
    class Program
    {
        public static void NoDuplicats(int[] arrayToPrint)
        {
            List<int> numbersToPrint = new List<int>();
            foreach(int number in arrayToPrint)
            {
                if (!numbersToPrint.Contains(number))
                {
                    numbersToPrint.Add(number);
                    Console.Write(number);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] testValue = {1,1,2,2,3};
            NoDuplicats(testValue);
        }
    }
}
