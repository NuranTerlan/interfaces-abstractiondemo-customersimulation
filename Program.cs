using System;
using System.Globalization;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            BaseCustomerManager customerManagerStarbucks = new StarbucksCustomerManager(new CustomerCheckManager());
            BaseCustomerManager customerManagerNero = new NeroCustomerManager();

            // CUSTOMER 1
            Customer customer1 = new Customer
            {
                ID = 1,
                FirstName = "Nuran",
                LastName = "Terlan",
                DateOfBirth = new DateTime(2002, 5, 16),
                NationalityId = "AZE19181358"
            };
            await customerManagerStarbucks.Save(customer1);
            customerManagerStarbucks.Details(customer1);


            // Customer 2
            Customer customer2 = new Customer
            {
                ID = 2,
                FirstName = "Orxan",
                LastName = "Kerimov",
                DateOfBirth = new DateTime(2001, 10, 4),
                NationalityId = "AZE20651192"
            };
            await customerManagerNero.Save(customer2);
            customerManagerNero.Details(customer2);
        }
    }
}
