using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerDal customerDal = new CustomerDal();
            Customer customer = new Customer
            {
                Id = 1,
                LastName = "Karataş",
                Age = 22
            };
            customerDal.AddCustomer(customer);
            Console.ReadKey();
        }
    }

    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Don't use AddCustomer, instead use AddCustomerNew Method")]
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added!",
                customer.Id, customer.FirstName,
                customer.LastName, customer.Age);
        }

        public void AddCustomerNew(Customer customer)
        {

        }
    }
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true )] // | AttributeTargets.Field
    class RequiredPropertyAttribute : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute:Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
