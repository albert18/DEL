using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //public delegate string MyDelegate(int arg1, int arg2);
    //public delegate void MyDelegate(int arg1, int arg2);
    public delegate void MyDelegate(int arg1, ref int arg2);


    #region Regular Delegate
    //class MyClass
    //{
    //    public string InstanceMethod(int arg1, int arg2)
    //    {

    //        return ((arg1 + arg2) * arg1).ToString();
    //    }
    //} 
    #endregion


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

        #region Composoble Delegate
        //static void func1(int arg1, int arg2)
        //{
        //    string result = (arg1 + arg2).ToString();
        //    Console.WriteLine(result);
            
        //}
        //static void func2(int arg1, int arg2)
        //{
        //    string result = (arg1 * arg2).ToString();
        //    Console.WriteLine(result);

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

            #region Anonymous function delegate
            //MyDelegate f = delegate (int arg1, int arg2)
            //{
            //    return (arg1 + arg2).ToString();
            //};
            //Console.WriteLine(f(10, 20));
            #endregion

            #region Composoble Delegate

            //MyDelegate f1 = func1;
            //MyDelegate f2 = func2;
            //MyDelegate f1f2 = f1 + f2;

            //Console.WriteLine("Calling the first delegate");
            //f1(10, 20);
            //Console.WriteLine("Calling the first delegate");
            //f2(10, 20);
            //Console.WriteLine("Calling the first delegate");
            //f1f2(10, 20);

            #endregion

            #region Composoble Delegate 2

            #endregion





            Console.ReadLine();

        }


    }
}
