using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetConsole.Assessments
{
    public class Logical
    {
        public void Go()
        {
            int x, y = 1;
            x = 10;
            if (x != 10 && x / Convert.ToInt32(0) == 0)
                Console.WriteLine(y);
            else
                Console.WriteLine(++y);
            Console.ReadLine();

            A obj1 = new A();
            B obj2 = new B();
            A r;
            r = obj1;
            r.display();
            r = obj2;
            r.display();

            int[] nums = { 1, -2, 3, 0, -4, 5 };
            int len = (from n in nums
                       where n > 0

                       select n).Count();

            Console.WriteLine("The number of positive values in nums: " + len);



            int[] nums1 = { 3, 1, 2, 5, 4 };
            var ltAvg = from n in nums1
                        let x1 = nums1.Average()
                        where n < x1
                        select n;
            Console.WriteLine("The average is " + nums.Average());


            int a = 5;
            int b = 0, c = 0;
            method(a, b, ref c);
            Console.WriteLine(b + "  " + c);

            Stack st = new Stack();
            st.Push("Csharp");
            st.Push(7.3);
            st.Push(8);
            st.Push('b');
            st.Push(true);


            sum p = new sum();
            p.math(12, 30);
           // Console.WriteLine(p.x + "  " + p.y);

            List<string> list1 = new List<string> { "A", "C", "E" };
            List<string> list2 = new List<string> { "B", "D" };
            List<string> result = new List<string>();
            foreach (var item in list1)
            {
                foreach (var item2 in list2)
                {
                    result.Add(item + item2);
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        class sum
        {
            public int x;
            private int y;
            public void math(int a, int b)
            {
                x = a * 4;
                y = b;
            }
        }


        class A
        {
            public virtual void display()
            {
                Console.WriteLine("A");
            }
        }
        class B : A
        {
            public override void display()
            {
                Console.WriteLine(" B ");
            }
        }
        static int method(int x, int p, ref int k)
        {
            p = x + x * x;
            k = x * x + p;
            return 0;
        }
    }

}
