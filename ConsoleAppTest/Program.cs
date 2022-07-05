using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int num = 5;
            double d = 5.23;
            float fl = 1.05f;

            B objB = new B();
            objB.abc(new Q());
            objB.abc(new P());

            objB.abc(d);
            objB.abc(fl);
            // A objA = new A();
            //objA.abc(i);
            Console.ReadLine();

            Console.WriteLine("Hello World");
        }
    }

    public class Q
    {
         

    }  // End of class Q

    public class P : Q
    {
     
    }  // End of class P
    public class A
    {
        public void abc(Q q)
        {
            Console.WriteLine("Print from Class A....!!! ");

        }
        public void abc(string str)
        {
            Console.WriteLine("Print from Class B String....!!! ");

        }

    }  // End of class A

    public class B : A
    {
        public void abc(P p)
        {
            Console.WriteLine("Print from Class A Float....!!! ");

        }
        public void abc(double i)
        {
            Console.WriteLine("Print from Class A Double....!!! ");

        }


         
    }  // End of class B
}
