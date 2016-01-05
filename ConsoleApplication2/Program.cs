using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    static class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            x.Test();

            var myCondition = false;
            myCondition = false;

            do
            {
                // Do something
                // Set myCondition = true
            } while (myCondition == false);

        }

        static void Main(string[] args)
        {
            StringBuilder y = new StringBuilder();
            y.Append("Hello");

            Foo(y);
            Console.WriteLine(y == null);

            Bar(ref y);
            Console.WriteLine(y == null);
        }

        static void Foo(StringBuilder x)
        {
            x = null;
        }

        static void Bar(ref StringBuilder x)
        {
            x = null;
        }

        public static void Test(this int value)
        {
            Console.WriteLine(value);
        }
    }
}