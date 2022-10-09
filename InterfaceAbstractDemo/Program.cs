using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarBucksCustomerManager(ICustomerCheckService );
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1997, 10, 8), FirstName = "Furkan", LastName = "Karain", NationalityId = "66769023032" });
        }
    }
}
