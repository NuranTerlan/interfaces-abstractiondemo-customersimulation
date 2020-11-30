using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        public override void Details(Customer customer)
        {
            Console.WriteLine($" =>  Details of ID{customer.ID} Customer ( ~ NERO ~ ) :\n" +
                              $"First Name : {customer.FirstName}\n" +
                              $"Last Name : {customer.LastName}\n" +
                              $"Date of Birth : {customer.DateOfBirth}\n" +
                              $"Nationality Identity : {customer.NationalityId}\n");
        }
    }
}
