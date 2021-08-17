using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    static class Calculator
    {
        static decimal A { get; set; }
        static decimal B { get; set; }

        static decimal Result { get; set; }

        public static void Substraction(decimal a, decimal b)
        {
            Result = a - b;
            Console.WriteLine($" 5 - 2 = {Result}");
        }
        public static void Addition(decimal a, decimal b)
        {
            Result = a + b;
            Console.WriteLine($" 5 + 2 = {Result}");
        }
        public static void Division(decimal a, decimal b)
        {
            Result = a / b;
            Console.WriteLine($" 5 / 2 = {Result}");
        }
        public static void Multiplication(decimal a, decimal b)
        {
            Result = a * b;
            Console.WriteLine($" 5 * 2 = {Result}");
        }


    }
}
