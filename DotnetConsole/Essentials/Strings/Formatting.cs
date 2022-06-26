using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetConsole.Essentials.Strings
{
    internal class Formatting
    {
        public static void Go()
        {
            string inputString = "abac";
            char[] arr = inputString.ToCharArray();
            bool isPallindrom = true;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                char c = arr[i];
                char c2 = arr[arr.Length - (i+1)];
                if (arr[i] != arr[arr.Length - (i+1)])
                {
                    isPallindrom = false;
                    break;
                }

            }

            float f1 = 123.4f;
            int i1 = 2000;

            // Spacing and Alignment: Indexes
            Console.WriteLine("{0,-15} {1,10}", "Float Val", "Int Val");
            Console.WriteLine("{0,-15} {1,10}", f1, i1);

            // Spacing and Alignment: Interpolation
            Console.WriteLine("{0,-15} {1,10}", "Float Val", "Int Val");
            Console.WriteLine($"{f1,-15} {i1,10}");
        }
    }
}
