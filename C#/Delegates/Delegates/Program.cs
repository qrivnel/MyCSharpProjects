using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int myDelegate3(int n1, int n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Matt matt = new Matt();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;   //SAME1

            //MyDelegate myDelegate2 = customerManager.ShowAlert;
            //myDelegate = myDelegate + myDelegate2;     //SAME1

            //myDelegate.Invoke();         //SAME2
            myDelegate();                //SAME2

            myDelegate -= customerManager.ShowAlert;
            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage;
            myDelegate2 += customerManager.ShowAlert;

            myDelegate2("This is a message");

            myDelegate3 myDelegate3 = matt.Plus;
            Console.WriteLine(myDelegate3(3, 5));
            myDelegate3 = matt.Multiply;
            Console.WriteLine(myDelegate3(3, 5));

            Console.ReadKey();
        }
    }

    class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hi!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Warning!");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    public class Matt
    {
        public int Plus(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
