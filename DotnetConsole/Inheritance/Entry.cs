using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetConsole.Inheritance
{
    public class Entry
    {
        public static void Go()
        {
            Child a = new Child();
            a.AM1();


        }
    }

    public class Base
    {
        public Base()
        {
            Console.WriteLine("Base - C");
        }

        public Base(string val)
        {
            Console.WriteLine("Base - C" + val);
        }

        public void AM1()
        {
            Console.WriteLine("Base - AM1");
        }

        public void AM2()
        {
            Console.WriteLine("Base - AM2");
        }
    }

    public class Child : Base
    {
        public Child()
        {
            
            Console.WriteLine("Child - C");
        }

        public void BM1()
        {
            Console.WriteLine("Child - BM1");
        }

        public void BM2()
        {
            Console.WriteLine("Child - BM2");
        }
    }
}
