using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceWebAPI.Models;

namespace ECommerceWebAPI.Data.Repositories
{
    public class EFCustomerRepository : ICustomerRepository
    {
        private readonly ApiDbContext _context;

        public EFCustomerRepository(ApiDbContext context)
        {
            _context = context;
        }
        public void Add(Customer item)
        {
            _context.customers.Add(item);
        }

        public void Delete(Guid id)
        {
            Customer item = Get(id);
            _context.customers.Remove(item);
        }

        public Customer Get(Guid id)
        {
            return _context.customers.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.customers.ToList();
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }

        public void Update(Customer item)
        {
            _context.customers.Update(item);
        }
    }
}
