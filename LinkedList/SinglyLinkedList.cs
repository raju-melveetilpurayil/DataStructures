using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class SinglyLinkedList<T>
    {
        private Node<T> head { get; set; }
        private Node<T> tail { get; set; }
        public void Searchq(T search)
        {
            Console.WriteLine($"Searching {search} the Linked List");

            bool found = false;

            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.GetHashCode() == search.GetHashCode())
                {
                    found = true;
                    break;
                }
                current = current.Next;
            }

            Console.WriteLine($"{search} {(found ? "" : "not ")}found in the Linked List");
            Console.WriteLine();

        }
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
            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
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

            Node<T> current = head;
            Node<T> previous = head;
            while (current != null)
            {
                if (current.Data.GetHashCode() == item.GetHashCode())
                {
                    if (current == head)
                    {
                        head = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }
                    break;
                }
                previous = current;
                current = current.Next;
            }
            Console.WriteLine();
        }
        public  void Reverse()
        {
            var current = head;
            tail = head;
            Node<T> previous = null;

            while (current!= null)
            {
                var temp = current.Next;
                current.Next = previous;
                previous = current;
                current=temp;
            }
            head = previous;
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
