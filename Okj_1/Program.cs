using System;

namespace Okj_1
{
    class Program
    {
        static Random rnd = new Random();
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vincze Máté");
            for (int i = 0; i < 100; i++)
            {
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth),
                    rnd.Next(Console.WindowHeight));
                    Console.Write("*");
            }
            Console.ReadKey(true);
        }
    }
}
