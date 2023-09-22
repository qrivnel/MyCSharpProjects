using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariLinkedList
{
    /*
    PDF'teki kodda yazım hataları var. Örneğin parametre olarak şfl yazılmış ve ders diye bir değişken yok.
    */
    public class Imployee
    {
        public string _name;
        public int _id;
        public Imployee(string name, int id)
        {
            _name = name;
            _id = id;
        }
    }
    public class Node
    {
        public Imployee data;
        public Node next;
        public Node(Imployee imployee)
        {
            data = imployee;
            next = null;
        }
    }
    public class Program
    {
        public static Imployee NewEmployee(string name, int id)
        {
            Imployee imployee = new Imployee(name, id);
            return imployee;
        }
        static void Main(string[] args)
        {
            //Link List'in oluşturulması
            Node head = new Node(NewEmployee("Erhan", 1));
            Node n1 = new Node(NewEmployee("Ali", 2));
            Node n2 = new Node(NewEmployee("Ayşe", 3));
            Node tail = new Node(NewEmployee("Karataş", 5));

            head.next = n1;
            n1.next = n2;
            n2.next = tail;
            
            //Test
            AddNextNode(n2);
            AddTailNode(n2);
            while (head != null)
            {
                Console.WriteLine("Imployee Name: " + head.data._name);
                Console.WriteLine("Imployee Id: " + head.data._id);
                Console.WriteLine();
                head = head.next;
            }

            Console.ReadKey();
        }
        public static void AddNextNode(Node node)
        {
            Node newNode = new Node(NewEmployee("newNode", 4));
            newNode.next = node.next; 
            node.next = newNode;
        }
        public static void AddTailNode(Node node)
        {
            Node tail = new Node(NewEmployee("tailNode", 6)); //PDF'teki kodda Türkçe karakterler kullanılmış.
                                                              //Örneğin parametre olarak şfl yazılmış ve
                                                              //ders diye bir değişken yok.

            while (node != null)                              //Tail'i bulmak için döngü              
            {
                if (node.next == null)
                {
                    node.next = tail;   
                    tail.next = null;
                    break;
                }
                node = node.next;
            }
        }
    }
    
    
}
