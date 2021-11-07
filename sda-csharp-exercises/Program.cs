using System;

namespace sda_csharp_exercises
{
    class Program
    {
        public static void aritarithmeticProgression(int startValue, int steps, int value)
        {
            
            for(int i = 0; i < steps; i++)
            {
                Console.WriteLine(startValue);
                startValue += value;

            }
        }
        static void Main(string[] args)
        {
            aritarithmeticProgression(12, 12, -4);
        }
    }
}
