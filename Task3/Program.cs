using System;

namespace Task3
{
    static class ExtensionClass
    {
        public static void ExtensionMethod1(this int[] value)
        {
            Array.Sort(value);
        }
    }
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int[] arr = new int[10];

            Console.WriteLine("Before sorting: ");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(101);
                Console.Write(arr[i] + " ");
            }

            arr.ExtensionMethod1();
            Console.WriteLine("\n \nAfter sorting: ");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
