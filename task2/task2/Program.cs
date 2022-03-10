using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -5, -10, -30, -40, -55, -67, -89, -90 };
            Positive(ref arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Positive(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<0)
                {
                    arr[i]=arr[i] * -1;
                }
            }
        }
    }
}
