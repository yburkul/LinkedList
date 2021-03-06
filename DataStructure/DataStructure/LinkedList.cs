using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        public Node Head;
        public Node Tail;
        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
        public void AppendNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }
        public void AddNodeAtStart(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
        public void DeleteNodeAtFirst()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Nothing to delete");
            }
            Node temp = this.Head;
            this.Head = this.Head.next;
        }
        public void DeleteNodeAtLast()
        {
            if (Head == null)
            {
                Console.WriteLine("Nothing to delete");
            }
            else
            {
                Node temp = Head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                Tail = temp;
                Console.WriteLine("\n Delete the last node: " + temp.next.data);
                temp.next = null;
            }
        }
        internal void Display()
        {
            Node temp = Head;
            if (temp == null)
            {
                Console.WriteLine("LinkList is empty");
            }
            else
            {
                Console.WriteLine("LinkList as follows: ");

            }
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                {
                    Console.Write("-> ");
                }
                temp = temp.next;
            }
        }
        public bool search(int data)
        {
            Node temp = this.Head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return true;
                }
                temp = temp.next;

            }
            return false;
        }
        public void AddSpecificNode(int Data, int Pos)
        {
            Node temp = new Node(Data);
            if (Pos == 0)
            {
                temp.next = Head;
                Head = temp;
            }

            Node prev = Head;
            for (int i = 0; i < Pos -1; i++ )
            {
                prev = prev.next;
            }
            temp.next = prev.next;
            prev.next = temp;
        }

        public void DeleteSpecificNode(Node head, int Pos)
        {
            if (Pos == 0)
            {
                head = head.next;
            }

            Node temp = Head;
            for (int i = 0; i < Pos -1; i++ )
            {
                temp = temp.next;
            }
            temp.next = temp.next.next;
        }

        public void Add(int data)
        {
            Node node = new Node(data);
            Node current = Head, previous = null;
            while (current != null && current.data < node.data)
            {
                previous = current;
                current = current.next;
            }
            if (previous == null)
            {
                Head = node;
            }
            else
            {
                previous.next = node;
            }
            node.next = current;
        }
    }
}