using DotnetConsole.Essentials;
using System;


namespace DotnetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int again = 0;
            do
            {
                Essential.Go();
                Console.WriteLine("Again !! Press 1");
                again = Convert.ToInt32(Console.ReadLine());
            } while (again == 1);
        }

    }
}

