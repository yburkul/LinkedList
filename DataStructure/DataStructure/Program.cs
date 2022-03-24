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

            linkedlist.AddNode(node_1);
            linkedlist.AddNode(node_2);
            linkedlist.AddNode(node_3);
            linkedlist.Display();
        }
    }
}
