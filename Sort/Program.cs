// See https://aka.ms/new-console-template for more information
using Sort.Algorithms;
using Sort.Structure;

Console.WriteLine("Welcome to LinkedList!");

MyLinkedList list = new MyLinkedList();
list.Add(10);
list.Add(80);
list.Add(30);
list.Add(90);
list.Add(40);

list.Sort();

Dump(list);


void Dump(MyLinkedList list)
{
    Console.WriteLine("List Print...");
    foreach (int item in list.GetEnumerator())
    {
        Console.WriteLine(item);
    }
}

