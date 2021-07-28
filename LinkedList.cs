using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class LinkedList<T>
    {
        private Node<T> head { get; set; }
        public bool Search(T search)
        {
            bool found = false;

            Node<T> current = head;
            if (current != null)
            {
                while (current.Next != null && current.Data.ToString() != search.ToString())
                {
                    current = current.Next;
                }
                if (current.Data.ToString() == search.ToString())
                {
                    found = true;
                }
            }

            return found;
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
