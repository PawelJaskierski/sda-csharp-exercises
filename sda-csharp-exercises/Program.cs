using System;

namespace sda_csharp_exercises
{
    class Program { 
        public static string NaturalToLeet(string txt)
        {
          char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };
          char[] charArray = txt.ToLower().ToCharArray(); 
            for(int j = 0; j < charArray.Length; j++)
            {
                for(int i = 0; i < 5; i++)
                {
                    if(charArray[j] == naturalLetters[i])
                    {
                        charArray[j] = naturalLetters[i];
                    }
                }
            }
            return new string(charArray);
        }

        public static string LeetToNatural(string txt)
        {

            char[] leetLetters = { '4', '3', '1', '0', '$' }; 
            char[] charArray = txt.ToCharArray();
            for (int j = 0; j < charArray.Length; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (charArray[j] == leetLetters[i])
                    {
                        charArray[j] = leetLetters[i];
                    }
                }
            }
            return new string(charArray);

        }

        static void Main(string[] args)
        {
            Console.WriteLine(LeetToNatural("4$14"));
            Console.WriteLine(NaturalToLeet("Asia"));
            Console.WriteLine(new char[] { 'a','b'}.ToString());
        }
    }
}
