using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete;
using Entities.Concrete;

namespace MaskChasing
{
    public class Program
    {
        static void Main(string[] args)
        {
            PttManager trCitizen = new PttManager(new PersonManager());
            trCitizen.GiveMask(new Person(0,"Erhan","Karataş"));

            PttManager foreignCitizen = new PttManager(new ForeignManager());
            foreignCitizen.GiveMask(new Person(1, "John", "Wick"));

            Console.ReadLine();
        }
    }
}
