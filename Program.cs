using MathClass;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number .");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now Pick another number if you want, if not push enter");
            var num2 = (Console.ReadLine());
            
            Integers intobj1 = new Integers();
            if (num2 == "")
            {
                int result = intobj1.myMethod(num1);
                Console.WriteLine(result);
                Console.ReadLine();
            }
            else
            {
                int num3 = Convert.ToInt32(num2);
                int result2 = intobj1.myMethod(num1, num3);
                Console.WriteLine(result2);
                Console.ReadLine();
            }
           }
    }
}
