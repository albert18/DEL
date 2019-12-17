using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate string MyDelegate(int arg1, int arg2);


    class MyClass
    {
        public string InstanceMethod(int arg1, int arg2)
        {

            return ((arg1 + arg2) * arg1).ToString();
        }
    }


    class Program
    {
        #region Regular Delegate
        //static string func1(int a, int b)
        //{
        //    return (a + b).ToString();
        //}
        //static string func2(int a, int b)
        //{
        //    return (a * b).ToString();
        //} 
        #endregion

        static void Main(string[] args)
        {
            #region Regular Delegate
            //MyDelegate f = func1;
            //Console.WriteLine("The number is " + f(10, 20));

            //MyClass mc = new MyClass();
            //f = mc.InstanceMethod;
            //Console.WriteLine("The number is " + f(10, 20));
            #endregion






            Console.ReadLine();
        }


    }
}
