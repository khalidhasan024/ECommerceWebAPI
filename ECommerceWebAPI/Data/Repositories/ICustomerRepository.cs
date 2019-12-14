using ECommerceWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWebAPI.Data.Repositories
{
    interface ICustomerRepository
    {
        void Add(Customer item);
        Customer Get(Guid id);
        IEnumerable<Customer> GetAll();
        void Update(Customer item);
        void Delete(Guid id);
        bool Save();
    }
}
