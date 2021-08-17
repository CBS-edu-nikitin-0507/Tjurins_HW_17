using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Addition(5,2);
            Calculator.Substraction(5, 2);
            Calculator.Division(5, 2);
            Calculator.Multiplication(5, 2);

            Console.Read();
        }
    }
}
