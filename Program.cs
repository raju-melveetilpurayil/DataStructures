using System;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 4, 3, 5, 7, 9 };
            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                linkedList.Add(numbers[i]);
            }
        }
    }
}
