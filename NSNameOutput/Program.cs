using System;

namespace NSNameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int additionalSymbolsCount = 2;
            
            Console.Write("Введите желаемый символ: ");
            char userSymbol = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите ваше имя: ");
            string userName = Console.ReadLine();

            for (int i = 0; i < userName.Length + additionalSymbolsCount; i++)
            {
                Console.Write(userSymbol);
            }
            Console.WriteLine($"\n{userSymbol}{userName}{userSymbol}");

            for (int i = 0; i < userName.Length + additionalSymbolsCount; i++)
            {
                Console.Write(userSymbol);
            }
            Console.ReadKey();
        }
    }
}