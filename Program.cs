using System;

namespace SumAndMultiply
{
    class Program
    {
        //static int Sum(int[] list)
        static int Sum(params int[] list)
        {
            int accum = 0;
            foreach (int n in list)
                accum += n;
            return accum;
        }

        //static int Product(int[] list)
        static int Product(params int[] list)
        {
            int accum = 1;
            foreach (int n in list)
                accum *= n;
            return accum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            int[] input = new int[args.Length];
            int i = 0;
            Console.WriteLine("Here are the command-line parameters:");
            foreach (string s in args)
            {
                Console.WriteLine(s);
                input[i++] = Convert.ToInt32(s);
            }

            int sums = Sum(input);
            int prods = Product(input);

            Console.WriteLine($"\nThe sum of these numbers is {sums} and the product is {prods}");

        }
    }
}
