using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetConsole.Assessments
{
    public class Solitair
    {
        public delegate void DisplayDelegate();
        public static void Go()
        {
            // Entry.Go();
            // Essential.Go();
            //Stack stack = new Stack();
            //stack.Push("Hell");
            //stack.Push(4.5);
            //stack.Push(true);

            //try
            //{
            //    Console.WriteLine("try");
            //    return;

            //}
            //finally
            //{
            //    Console.WriteLine("Finally");
            //}

            //DisplayDelegate d1 = new DisplayDelegate(D1);
            //DisplayDelegate d2 = new DisplayDelegate(D2);

            //d1 = d1 + d2;
            //d1();

            //StringBuilder s1=new StringBuilder("S1");
            //StringBuilder s2 = new StringBuilder("S1");

            //Console.WriteLine(s1 == s2);
            //Console.WriteLine(s1.Equals(s2));




            string X1_Input, M1_Input, X2_Input;

            X1_Input = Console.ReadLine();
            M1_Input = Console.ReadLine();
            X2_Input = Console.ReadLine();

            int x1 = Convert.ToInt32(X1_Input);
            int m1 = Convert.ToInt32(M1_Input);
            int x2 = Convert.ToInt32(X2_Input);
            string result = Solve(x1, m1, x2);

            Console.WriteLine(result);
            Console.ReadLine();

            //String line;
            //line = Console.ReadLine();
            //int N = Convert.ToInt32(line);

            //String out_ = findNextBiggest(N);
            //Console.Out.WriteLine(out_);
        }

        static String findNextBiggest(int N)
        {
            string res = "Not Possible";
            char[] arr = N.ToString().ToCharArray();
            int[] ints = Array.ConvertAll(arr, s => Convert.ToInt32(s.ToString())).ToArray();
            Array.Sort(ints);
            Array.Reverse(ints);

            var builder = new StringBuilder();
            Array.ForEach(ints, x => builder.Append(x));
            int largestNo = Convert.ToInt32(builder.ToString());

            if (N < largestNo)
            {
                res = largestNo.ToString();
            }


            return res;
            // You must complete the logic for the function that is provided
            // before compiling or submitting to avoid an error.
            // Write your code here

        }

        public static string Solve(int x1, int m1, int x2)
        {
            string res = "Not Possible";
            double num = Math.Pow(10, 4);
            double petrol = 2;
            double m2 = 0;
            while (petrol > 1 && petrol <= num && petrol != 0)
            {
                double x1Distance = m1 * petrol;
                double x1actualDistance = x1 + x1Distance;
                double x2RemainingDistance = x1actualDistance - x2;

                if (x2RemainingDistance % petrol == 0)
                {
                    m2 = x2RemainingDistance / petrol;
                    if (m2 > 1)
                    {
                        res = $"{petrol} {m2}";
                        petrol = 0;
                        break;
                    }

                }
                petrol++;
            }

            return res;
        }

        public static void D1()
        {
            Console.WriteLine("D1");
        }

        public static void D2()
        {
            Console.WriteLine("D2");
        }
    }
}
