using NUnit.Framework;
using Sort.Structure;
using Sort.Algorithms;

namespace Sort.Tests
{
    public class QuickSortTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWithArray()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(10);
            list.Add(80);
            list.Add(30);
            list.Add(90);
            list.Add(40);

            list.Sort();
            var expect = new int[] { 10, 30, 40, 80, 90 };
            Assert.AreEqual(expect, list.ToArray());
        }

        [Test]
        public void TestWith2items()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(10);
            list.Add(80);

            list.Sort();
            var expect = new int[] { 10, 80 };
            Assert.AreEqual(expect, list.ToArray());
        }

        [Test]
        public void TestWith1item()
        {
            MyLinkedList list = new MyLinkedList();
            list.Add(10);

            list.Sort();
            var expect = new int[] { 10 };
            Assert.AreEqual(expect, list.ToArray());
        }

        [Test]
        public void TestWithEmpty()
        {
            MyLinkedList list = new MyLinkedList();

            list.Sort();
            var expect = new int[] { };
            Assert.AreEqual(expect, list.ToArray());
        }
    }
}