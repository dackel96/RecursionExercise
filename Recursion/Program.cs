using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(Sum(array, 0));

            int integerValue = int.Parse(Console.ReadLine());
            Console.WriteLine(NFactorial(integerValue));
        }
        static int Sum(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }
            return arr[index] + Sum(arr, index + 1);
        }
        static int NFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * NFactorial(n - 1);
        }
    }
}
