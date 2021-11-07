using System;
using System.Collections.Generic;
using System.Linq;
namespace sda_csharp_exercises
{
    class Program
    {
        
        public static bool PESELCheker(string PESEL)
        {
            int[] weightTable = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int suma = 0;
            for (int i = 0; i < PESEL.Length-1; i++)
            {
                suma += (Convert.ToInt32(PESEL[i]) - 48)*weightTable[i];

            }
            suma %= 10;

            return (10 - suma == Convert.ToInt32(PESEL[PESEL.Length - 1])-48 || (suma == 0 && Convert.ToInt32(PESEL[PESEL.Length - 1])-48 == 0));

        }
        static void Main(string[] args)
        {
            Console.WriteLine(PESELCheker("55030101193"));
        }
    }
}
