using System;
using System.Collections.Generic;
using System.Linq;
namespace sda_csharp_exercises
{
    class Program
    {
        public static int[] BubbleSort(int[] table)
        {
            for(int i = 0; i < table.Length-1; i++)
            {
                for(int j = 0; j < table.Length-i-1; j++)
                {
                    if(table[j] > table[j + 1])
                    {
                        Swap(ref table[j], ref table[j+1]);

                    }
                }
            }
            return table;
        }
        public static void Swap(ref int x, ref int y)
        {
            int temp = 0;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int[] answer;
            answer = BubbleSort(new int[] { 7,1234,1,5,23,532,6 });
            foreach(int number in answer)
            {
                Console.WriteLine(number);
            }

        }
    }
}
