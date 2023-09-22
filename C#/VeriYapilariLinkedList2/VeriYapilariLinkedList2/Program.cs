using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariLinkedList2
{
    public class Program
    {
        public static Node FindTail(Node head)
        {
            while (head != null)
            {
                if (head.next == null)
                    return head;
                head = head.next;
            }
            return null;
        }
        public static Employee NewEmployee(string name, string surname, int id, decimal salary)
        {
            Employee employee = new Employee(name, surname, id, salary);
            return employee;
        }
        static void Main(string[] args)
        {
            //İlk personeller ile LinkedList oluşturulması
            Node head = new Node(NewEmployee("Erhan", "Karataş", 1 ,19500));
            Node n1 = new Node(NewEmployee("Ali", "Öz", 2, 12000));
            Node n2 = new Node(NewEmployee("Ayşe", "Taş", 3, 10000));
            Node n3 = new Node(NewEmployee("Ahmet", "Albayrak", 4, 8500));

            head.next = n1;
            n1.next = n2;
            n2.next = n3;
            n3.next = null;

            //Test//

            //Ekleme
            AddNode(head);

            //Arama
            //Linear Search
            Console.Write("Search Name: ");
            string name = Console.ReadLine();
            List<Node> list = SearchByName(head, name);
            foreach(Node wanted in list)
                if (wanted != null)
                    Console.WriteLine("\nSearch Info:\nImployee Id: " + wanted.data._id + "\nImployee Name: " + wanted.data._name + "\nImployee Salary: " + wanted.data._salary + "\n");

            

            //Binary Search
            int listLength = 0;
            Console.Write("Search Id: ");
            int searchId = Convert.ToInt32(Console.ReadLine());
            Node tmpHead = head;
            while (tmpHead != null)  //Link Listed uzunluğu
            {
                listLength++;
                tmpHead = tmpHead.next;
            }
            SearchById(head, searchId, listLength);


            

            //Ekrana yazdırma
            while (head != null)
            {
                Console.WriteLine();
                Console.WriteLine("Employee Id: " + head.data._id);
                Console.WriteLine("Employee Name: " + head.data._name);
                Console.WriteLine("Employee Surname: " + head.data._surname);
                Console.WriteLine("Employee Salary: " + head.data._salary);
                
                head = head.next;
            }
            
            
            Console.ReadKey();
        }
        public static void SearchById(Node head, int id, int listLength)
        {
            Node start = head;
            Node end = FindTail(head);

            while (start != null && end != null && listLength > 0)
            {
                int middleIndex = listLength / 2;
                Node middleNode = start;

                for (int i = 0; i < middleIndex; i++)
                {
                    middleNode = middleNode.next;
                }

                if (middleNode.data._id == id)
                {
                    Console.WriteLine("\nSearch Info:\nImployee Id: " + middleNode.data._id + "\nImployee Name: " + middleNode.data._name + "\nImployee Salary: " + middleNode.data._salary + "\n");
                    return;
                }
                else if (middleNode.data._id < id)
                {
                    start = middleNode.next;
                    listLength = listLength - (middleIndex + 1);
                }
                else
                {
                    end = middleNode;
                    listLength = middleIndex;
                }
            }
            Console.WriteLine("\nEmployee not found.\n");
        }
        public static List<Node> SearchByName(Node head, string name)
        {
            List<Node> nodeList = new List<Node>();
            while(head != null)
            {
                if (head.data._name.ToLower() == name.ToLower())
                    nodeList.Add(head);
                head = head.next;
            }
            return nodeList;
        }
        public static void AddNode(Node head)
        {
            Console.Write("Enter the name of Employee: ");
            string name = Console.ReadLine();
            Console.Write("Enter the surname of Employee: ");
            string surname = Console.ReadLine();
            Console.Write("Enter the salary of Employee: ");
            decimal salary =Convert.ToDecimal(Console.ReadLine());
            Node newNode = new Node(NewEmployee(name, surname, FindTail(head).data._id + 1, salary));
            FindTail(head).next = newNode;
            newNode.next = null;
        }
    }
    
    public class Employee
    {
        public int _id;
        public string _name;
        public string _surname;
        public decimal _salary;
        public Employee(string name, string surname, int id, decimal salary)
        {
            _name = name;
            _surname = surname;
            _id = id;
            _salary = salary;
        }
    }
    public class Node
    {
        public Employee data;
        public Node next;
        public Node(Employee employee)
        {
            data = employee;
        }
    }

}
