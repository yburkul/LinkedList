using System;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        static void Main()
        {
            LinkedList linkedlist = new LinkedList();
            Node node_1 = new Node(21);
            Node node_2 = new Node(22);
            Node node_3 = new Node(23);
            Node node_4 = new Node(24);
            Node node_5 = new Node(25);

            linkedlist.AddNode(node_1);
            linkedlist.AddNode(node_2);
            linkedlist.AddNode(node_3);
            linkedlist.Display();

            Console.WriteLine("Add a new Node");
            linkedlist.AppendNode(node_4);
            linkedlist.AppendNode(node_5);
            linkedlist.Display();
        }
    }
}
