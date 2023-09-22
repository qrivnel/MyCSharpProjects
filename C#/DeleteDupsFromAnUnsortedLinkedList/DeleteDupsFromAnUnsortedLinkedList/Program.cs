using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DeleteDupsFromAnUnsortedLinkedList
{
    internal class Program
    {
        public static void DeleteDups(Node head)
        {
            ArrayList set = new ArrayList();
            Node temp = head;

            while(temp != null && temp.next != null)
            {
                if (set.Contains(temp))
                {
                    temp = temp.next;
                    break;
                }
                Node runner = temp;
                while(runner.next != null)
                {
                    if(temp.data == runner.next.data)
                        runner.next = runner.next.next;
                    else
                        runner = runner.next;
                }
                temp = temp.next;
                    
            }

        }

        static void Main(string[] args)
        {
            Node head = new Node(9);
            Node n1 = new Node(5);
            Node n2 = new Node(6);
            Node n3 = new Node(9);
            Node n4 = new Node(2);
            Node n5 = new Node(5);
            Node tail = new Node(5);

            head.next = n1;
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = tail;
            tail.next = null;

            DeleteDups(head);

            while(head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }

            Console.ReadKey();
        }
    }
}
