using System;

namespace sda_csharp_exercises
{
    class Program
    {
        public static void Triangle(char sign, int lines)
        {
            for(int i = 0; i < lines; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }
            for (int i = lines; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Triangle('*', 20);
        }
    }
}
