using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnList
{

    class Program
    {
        static void Main(string[] args)
        {
            MyOwnLinkedList<int> list = new MyOwnLinkedList<int>();
            list.Add_Head(1);
            list.Add(2);
            
        }
    }
}
