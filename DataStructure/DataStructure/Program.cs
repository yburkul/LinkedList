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
            Node node_5 = new Node(15);

            Console.WriteLine("Node are added");
            linkedlist.AddNode(node_1);
            linkedlist.AddNode(node_2);
            linkedlist.AddNode(node_3);
            linkedlist.Display();

            Console.WriteLine("Add a new Node");
            linkedlist.AppendNode(node_4);
            linkedlist.Display();
            Console.WriteLine("\n New node is added: " + node_4.data);

            Console.WriteLine("Add node at Start Position:");
            linkedlist.AddNodeAtStart(node_5);
            linkedlist.Display();
            Console.WriteLine("\n At Start Position node is added: " + node_5.data);

            Console.WriteLine("Delete the First Node");
            linkedlist.DeleteNodeAtFirst();
            linkedlist.Display();
            Console.WriteLine("\n First node are deleted");

            linkedlist.DeleteNodeAtLast();
            linkedlist.Display();
            Console.WriteLine("\n Deleted the last node");


        }
    }
}
