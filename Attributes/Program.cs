﻿namespace Attributes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id =1, LastName="Demiroğ", Age = 32};
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
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
        [Obsolete("Don't use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    class RequiredPropertyAttribute : Attribute
    {
        
    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

}
