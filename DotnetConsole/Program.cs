using DotnetConsole.Essentials;
using DotnetConsole.Inheritance;
using System;

using DotnetConsole.Assessments;
namespace DotnetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int again = 0;
            do
            {



                // Entry.Go();
                // Essential.Go();



               // Console.WriteLine(Palindrom.Check(Console.ReadLine()));


                Console.WriteLine(StringAdjacentGreaterNumber.Check(Console.ReadLine()));
                Console.WriteLine("Again !! Press 1");
                again = Convert.ToInt32(Console.ReadLine());
            } while (again == 1);
        }
    }
}
