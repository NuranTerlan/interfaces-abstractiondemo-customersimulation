using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        Task Save(Customer customer);
        void Details(Customer customer);
    }
}
