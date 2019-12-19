using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    public delegate int MyDelegate(int x);
    public delegate void MyDelegate2(int x, string prefix);
    public delegate bool ExprDelegate (int x);

    class Program
    {
        static void Main(string[] args)
        {
            //Dynamic change lambda expression
            MyDelegate foo = (x) => x * x;
            Console.WriteLine("result {0}", foo(5));

            //statement lambda
            MyDelegate2 bar = (x, y) =>
            {
                Console.WriteLine("{0}, {1}", x * 10, y);
            };
            bar(25, "Some String");

            //Define expression delegate
            ExprDelegate baz = (x) => x > 10;
            Console.WriteLine("{0}", baz(5));


            Console.ReadLine();
        }
    }
}
