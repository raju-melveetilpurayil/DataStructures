using System;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 4, 3, 5, 7, 9 };

            SinglyLinkedList<int> linkedList = new SinglyLinkedList<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                linkedList.Add(numbers[i]);
            }
            linkedList.Print();
            linkedList.Reverse();
            linkedList.Print();


            linkedList.Add(15);
            linkedList.Print();

            linkedList.Delete(1);
            linkedList.Delete(3);
            linkedList.Delete(9);
            linkedList.Print();


            Console.ReadLine();
        }
    }
}
