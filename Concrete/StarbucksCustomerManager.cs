using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override Task Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
                return base.Save(customer);
            else
                throw new Exception($"{customer.FirstName} is not valid person");
        }

        public override void Details(Customer customer)
        {
            Console.WriteLine($" =>  Details of ID{customer.ID} Customer ( ~ STARBUCKS ~ ) :\n" +
                              $"First Name : {customer.FirstName}\n" +
                              $"Last Name : {customer.LastName}\n" +
                              $"Date of Birth : {customer.DateOfBirth}\n" +
                              $"Nationality Identity : {customer.NationalityId}\n");
        }
    }
}
