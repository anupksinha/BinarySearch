using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Test App Started");

            int[] arr = new int[] { 101, 301, 3, 56, 78, 45, 98, 123, -1 };
            Array.Sort(arr);
            System.Console.WriteLine("Array After Sort");
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
            int itemToFind = 101;
            int foundIndex = ProgramHelpers.BinarySearchWithIfState(arr, itemToFind, 0, arr.Length);
            if (foundIndex == -1)
            {
                System.Console.WriteLine("Item {0} not Fount in Array.", itemToFind);
            }
            else
            {
                System.Console.WriteLine("Item {0} Fount at index {1} in Array.", itemToFind, foundIndex);
            }
            System.Console.ReadLine();
        }
    }
}
