using System;

namespace sda_csharp_exercises
{
    class Program
    {
        public static float Power(float bas, int exponent)
        {
            float output = 1;
            if (exponent >= 0)
            {
                for (int i = 0; i<exponent; i++)
                {
                    output *= bas;
                }
                return output;
            }
            else
            {
                Console.WriteLine("Use positive number for the exponent");
                return float.NaN;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Power(2, 10));
        }
    }
}
