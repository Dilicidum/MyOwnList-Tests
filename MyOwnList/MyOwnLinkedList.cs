using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyOwnList
{
    public class MyOwnLinkedList<T> : IEnumerable<T>, ICollection<T>
    {

        private int count;
        public Node<T> head;
        public Node<T> last;

        public bool IsEmpty
        {
            get
            {
                if (head != null) return false;
                else return false;
            }
        }

        public int Count
        {
            get
            {
                try
                {

                    if (count < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    return count;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Count is below zero");
                    return count;
                }
            }
            private set
            {
                count = value;
            }
        }

        public void Add_Head(T data)
        {
            Node<T> node = new Node<T>(data);
            head = node;
            last = node;
            Count++;
        }

        public MyOwnLinkedList(params T [] array)
        {
            foreach(var i in array)
            {
                this.Add(i);
            }
        }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head != null)
            {
                last.Next = node;
                
            }
            else
            {
                head = node;
            }
            Count++;
            last = node;
        }

        public void Add_Tail(T data)
        {
            Node<T> node = new Node<T>(data);
            last.Next = node;
            last = node;
            Count++;
        }

        public void Clear()
        {
            head = null;
            Count = 0;
        }

        public void CopyTo(T[] array, int index)
        {
            for (int i = 0; i < Count; i++)
            {
                array[i + index] = this[i];
            }
        }

        bool ICollection<T>.Contains(T item)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Equals(item)) return true;
                current = current.Next;
            }
            return false;
        }

        public T this[int index]
        {
            get
            {
                return GetElementByIndex(index);
            }
            set
            {
                this[index] = value;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        private T GetElementByIndex(int index)
        {
            if (index < 0) throw new IndexOutOfRangeException();

            Node<T> current = head;
            int i = 0;
            while (current != null)
            {
                if (i == index)
                {
                    return current.Data;
                }
                current = current.Next;
                i++;
            }
            throw new IndexOutOfRangeException();
        }

        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;
            while (current != null)
            {
                if (current.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (previous.Next == null)
                        {
                            this.last = previous;
                        }
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                        {
                            this.last = null;
                        }
                    }
                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }

            return false;
        }

        public bool RemoveHead()
        {

            if (this.head != null)
            {
                if (this.head.Next != null)
                {
                    this.head = this.head.Next;
                    Count--;
                    return true;
                }
                else
                {
                    throw new ArgumentNullException();
                }
                
            }
            else
            {
                throw new ArgumentNullException();
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

    }
}
