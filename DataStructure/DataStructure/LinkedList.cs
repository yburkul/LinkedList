﻿using System;
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
            if (Head == null && Tail == null )
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
        public void AddNodeAtStart(Node node)
        {
            if(Head == null && Tail == null)
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
        public void DeleteNodeAtFirst()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Nothig to delete");
            }
            Node temp = this.Head;
            this.Head = this.Head.next;
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
    }
}