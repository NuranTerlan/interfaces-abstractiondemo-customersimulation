using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual async Task Save(Customer customer)
        {
            Console.WriteLine($"Query is sending to Database for {customer.FirstName} {customer.LastName} ( ID{customer.ID} )\n");
            await Task.Delay(1000);
            Console.Write(" * ");
            await Task.Delay(500);
            Console.Write(" * ");
            await Task.Delay(500);
            Console.Write(" * ");
            await Task.Delay(500);
            Console.Write(" * ");
            await Task.Delay(500);
            Console.Write(" * ");
            await Task.Delay(500);
            Console.Write(" * \n");
            await Task.Delay(500);
            Console.WriteLine($"\n{customer.FirstName} has been successfully saved to Database !\n");
        }

        public abstract void Details(Customer customer);
    }
}
