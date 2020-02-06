using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnList
{
    class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }

    public class MyOwnList<T>
    {
        Node<T> head;
        Node<T> tail;
        private int count;
        public int Count { get { return count; } private set { count = value; } }
        public bool isEmpty { get; private set; }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;
            Count++;
        }

        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    current = previous;
                    previous = current.Next;
                    return true;
                }
                else
                {
                    previous = current.Next;
                    current = current.Next;
                }
            }



        }

    }
    class Program
    {
        static void Main(string[] args)
        {



        }
    }
}
