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
                        int temp = 0;
                        temp = table[j];
                        table[j] = table[j + 1];
                        table[j + 1] = temp;

                    }
                }
            }
            return table;
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
