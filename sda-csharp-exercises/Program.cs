using System;

namespace sda_csharp_exercises
{
    class Program
    {
        public static void priceList(float price, int numberOfItems)
        {
            for(int i = 1; i <= numberOfItems; i++)
            {
                Console.WriteLine($"Liczba sztuk: {i} łączna cena: {i * price}zł");
            }
        } 
        static void Main(string[] args)
        {
            priceList(15, 10);
        }
    }
}
