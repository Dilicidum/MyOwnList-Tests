using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnList
{
    public class Node<T> : IEquatable<T>,IComparable<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            Data = data;
        }        

        public bool Equals(T other)
        {
            if (object.ReferenceEquals(other, null)) return false;
            if (object.Equals(this.Data, other)) return true;
            else return false;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(T other)
        {
            //if (this.Data.Equals(other)) return 0;
            
            return -1;
        }
    }
}
