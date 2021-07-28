using System;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 4, 3, 5, 7, 9 };

            SingleLinkedList<int> linkedList = new SingleLinkedList<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                linkedList.Add(numbers[i]);
            }

            linkedList.Print();
            linkedList.Delete(4);
            linkedList.Print();
            linkedList.Delete(9);
            linkedList.Print();

            linkedList.Search(5);
            linkedList.Search(10);

            Console.ReadLine();
        }
    }
}
