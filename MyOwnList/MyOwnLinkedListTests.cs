using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyOwnList
{
    [TestClass]
    public class MyOwnLinkedListTests
    {
        [TestMethod]
        public void AddHead_NodeBecomeHead()
        {
            MyOwnLinkedList<int> list = new MyOwnLinkedList<int>();
            list.Add_Head(13);
            Assert.AreEqual(13, list.head.Data);
        }

        [TestMethod]
        public void AddTail_NodeBecomeTail()
        {
            int last = 4;
            MyOwnLinkedList<int> list = new MyOwnLinkedList<int>();
            list.Add(2);
            list.Add_Tail(last);
            Assert.AreEqual(last, list.last.Data);
        }

        [TestMethod]
        public void RemoveHead_Next_Node_Should_Be_Head()
        {
            MyOwnLinkedList<int> list = new MyOwnLinkedList<int>();
            int[] array = new int[] { 1, 2, 5, 7, 10};
            foreach(var i in array)
            {
                list.Add(i);
            }
            
            list.RemoveHead();

            Assert.AreEqual(2, list.head.Data);
        }

        [TestMethod]
        public void Find_5_Should_Return_True()
        {
            int[] myNums = { 1, 2, 3, 4, 5 };

            var myLinkedList = new LinkedList<int>(myNums);

            var isFound = myLinkedList.Contains(5);

            Assert.IsTrue(isFound);
        }

        [TestMethod]
        public void Remove_1_Should_Return_True()
        {
            int[] myNums = { 1, 10, 5, 3, 2};

            var myLinkedList = new LinkedList<int>(myNums);

            bool isRemoved = myLinkedList.Remove(1);

            Assert.IsTrue(isRemoved);
        }

        [TestMethod]
        public void Remove_2_Should_Return_False()
        {
            MyOwnLinkedList<int> myLinkedList = new MyOwnLinkedList<int>(1);

            bool isRemoved = myLinkedList.Remove(2);

            Assert.IsFalse(isRemoved);
        }

        [TestMethod]
        public void AddHead_Should_Increment_Count()
        {
            var myLinkedList = new MyOwnLinkedList<int>();

            var theCount = myLinkedList.Count;

            myLinkedList.Add_Head(2);
            myLinkedList.Add(2);
            
            Assert.AreEqual(theCount + 2, myLinkedList.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetElementByIndex_ShouldThrow_IndexOutOfRangeException()
        {
            MyOwnLinkedList<int> list = new MyOwnLinkedList<int>();
            list.Add_Head(1);
            list.Add(2);
            Console.WriteLine(list[2]);
        }
    }
    
}
