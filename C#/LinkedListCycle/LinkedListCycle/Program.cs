using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListCycle
{
    internal class Program
    {
        public static bool LinkedListContains(List<Node> LinkedList, Node head)
        {
            foreach(Node node in LinkedList)
                if(node == head)
                    return true;
            return false;
        }
        public static void CycleControl(Node node)
        {
            Node head = node, current = node;
            List<Node> LinkedList = new List<Node>();
            while (true)
            {
                if (!LinkedListContains(LinkedList, current))
                {
                    LinkedList.Add(current);
                    current = current.next;
                }
                else 
                {
                    Console.WriteLine(current.data + " " + current.next.data);
                    break; 
                }
            }
            
        }
        static void Main(string[] args)
        {
            Node head = new Node(2);
            Node n1 = new Node(3);
            Node n2 = new Node(7);
            Node n3 = new Node(3);
            Node n4 = new Node(9);
            Node n5 = new Node(1);
            Node tail = new Node(0);

            head.next = n1;
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = tail;
            tail.next = n5;

            CycleControl(head);

            Console.ReadKey();
        }
    }
}
