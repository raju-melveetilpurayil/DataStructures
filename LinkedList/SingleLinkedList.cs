using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class SingleLinkedList<T>
    {
        private Node<T> head { get; set; }
        public void Search(T search)
        {
            Console.WriteLine($"Searching {search} the Linked List");

            bool found = false;

            Node<T> current = head;
            if (current != null)
            {
                while (current.Next != null && current.Data.GetHashCode() != search.GetHashCode())
                {
                    current = current.Next;
                }
                if (current.Data.GetHashCode() == search.GetHashCode())
                {
                    found = true;
                }
            }
            Console.WriteLine($"{search} {(found ? "" : "not ")}found in the Linked List");
            Console.WriteLine();

        }
        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
            Node<T> current = head;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public void Print()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Console.WriteLine("Printing the Linked List");
            if (head != null)
            {
                Node<T> current = head;
                while (current != null)
                {
                   
                    stringBuilder.Append("[");
                    stringBuilder.Append(current.Data);
                    if (current.Next != null) { stringBuilder.Append("|]->"); } else { stringBuilder.Append("|]"); }
                    current = current.Next;
                }
            }
            Console.WriteLine(stringBuilder.ToString());
            Console.WriteLine();
        }
        public void Delete(T item)
        {
            Console.WriteLine($"Deleting {item} from Linked List");
            if (head != null)
            {
                var current = head;
                //if deleteing head
                if (current.Data.GetHashCode() == item.GetHashCode())
                {
                    if (current.Next != null)
                    {
                        head = current.Next;
                    }
                    else
                    {
                        head = null;
                    }
                }
                else
                {
                    while (current.Next != null && current.Next.Data.GetHashCode() != item.GetHashCode())
                    {
                        current = current.Next;
                    }

                    if (current.Next.Data.GetHashCode() == item.GetHashCode())
                    {
                        //Delete the connection
                        current.Next = current.Next.Next;
                    }
                }
            }
            Console.WriteLine();
        }
    }
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; } = null;
        public Node(T data, Node<T> next = null)
        {
            Data = data;
            Next = next;
        }
    }
}
