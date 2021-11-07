using System;
using System.Text.RegularExpressions;


namespace sda_csharp_exercises
{
    class Program
    {
        public static bool passwordChecker(string password)
        {
            return Regex.IsMatch(password,"[a-z]") && Regex.IsMatch(password, "[A-Z]") && Regex.IsMatch(password,"[&*$#]") && password.Length >=6;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(passwordChecker("Lubie$"));
            Console.WriteLine(passwordChecker("a"));
            Console.WriteLine(passwordChecker("Lubie dolary"));
            Console.WriteLine(passwordChecker("lubie male litery"));
            Console.WriteLine(passwordChecker("JESTEM ZLY"));
        }
    }
}
