using System;

namespace NSNameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "";

            Console.Write("Введите желаемый символ: ");
            char userSymbol = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите ваше имя: ");
            string userName = Console.ReadLine();
            string secondLine = userSymbol + userName + userSymbol;
            int lineLength = secondLine.Length;

            for (int i = 0; i < lineLength; i++)
            {
                line += userSymbol;
            }
            Console.WriteLine($"{line}\n{userSymbol}{userName}{userSymbol}\n{line}");
            Console.ReadKey();
        }
    }
}