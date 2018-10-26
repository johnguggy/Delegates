using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHandler
{
   public class MethodClass
   {
   }

   class Program
   {
       //Step 1
       public delegate void Del(string message);

       static void Main(string[] args)
       {
           //Step 2
           Del d1 = Method1;
           Del d2 = Method2;
           Del d3 = Method3;

           //Step 3
           //Both types of assignment are valid.
           Del allMethodsDelegate = d3 + d2 + d1;
           allMethodsDelegate += d1;
           allMethodsDelegate += d2;
           allMethodsDelegate += d3;

           allMethodsDelegate -= d2;
           //Del allMethodsDelegate = Method1 + Method2 + Method3; //Error: Not allowed

           //Step 4
           allMethodsDelegate("Test");
       }


       public static void Method1(string message)
       {
           Console.WriteLine("Method1() called: " + message);
       }

       public static void Method2(string message)
       {
           Console.WriteLine("Method2() called: " + message);
       }

       public static void Method3(string message)
       {
           System.Console.WriteLine("Method3() Called: " + message);
       }

   }
}