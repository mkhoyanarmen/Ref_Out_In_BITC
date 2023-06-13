using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref__Out__In
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 8;

            Console.WriteLine("----Swap----");
            Console.WriteLine($"a = {a}\tb = {b}");

            swap(ref a, ref b);

            Console.WriteLine($"a = {a}\tb = {b}");
            Console.WriteLine();

            Console.WriteLine("----findMax----");
            int[] array = { 5, -8, 46, 10, 0, 458, 88, 32};
            printArr(array);
            int max;
            Console.WriteLine("\n----maxOfArray----");
            findMax(out max, array);
            Console.WriteLine(max);

            Console.WriteLine("\n----Modified Array----");
            modifyArr(ref array);
            printArr(array);
            Console.WriteLine();
        }
        static void swap(ref int a, ref int b)
        {
            int swap = a;
            a = b;
            b = swap;
        }
        static void findMax(out int max, int[] array)
        {
            max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
        }
        static void printArr(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
        }
        static void modifyArr(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= 2;
            }
        }
    }
}
