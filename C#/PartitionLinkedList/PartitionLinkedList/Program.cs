using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PartitionLinkedList
{
    internal class Program
    {
        public static void SortedLinkedList(Node node)
        {
            Node head = node, current = head.next, prev = null, cPrev = head.next;
            while(head != null && head.next != null)
            {
                prev = head;
                head = head.next;
                cPrev = head;
                current = head.next;
                while(current != null)
                {
                    if(head.data < current.data)
                    {
                        cPrev = current;
                        current = current.next;
                    }
                    else
                    {
                        prev.next = current;
                        cPrev.next = current.next;
                        current.next = head;
                        SortedLinkedList(node);
                        break;
                    }
                }
            }
        }
        public static Node PartitionLinkedList(Node node, int value)
        {
            Node head = node, prev = null, current = head;
            
            while(current != null)
            {
                if(prev == null || current.data >= value)
                {
                    prev = current;
                    current = current.next;
                }
                else
                {
                    prev.next = current.next;
                    current.next = head;
                    head = current;
                    current = prev.next;
                }
            }

            return head;

        }
        static void Main(string[] args)
        {
            Node head = new Node(0);
            Node n1 = new Node(3);
            Node n2 = new Node(7);
            Node n3 = new Node(5);
            Node n4 = new Node(9);
            Node n5 = new Node(1);
            Node tail = new Node(2);

            head.next = n1;
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = tail;

            //head = PartitionLinkedList(head, 3);

            SortedLinkedList(head);

            while (head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }



            Console.ReadKey();
        }
    }
}
