using DataAccess.Abstarct;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCustomerDal:ICustomer
    {


        List<Customer> _customers;
        public InMemoryCustomerDal()
        {
            _customers = new List<Customer>
             {
                 new Customer() {Name="Berkant",LastName = "Demiroğlu",Id=1},
                 new Customer() {Name="Berkay",LastName = "Çetin",Id=2},
                 new Customer() {Name="Seçkin",LastName = "Gürlek",Id=3 }
             };
        }
        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public void Delete(Customer customer)
        {
            Customer customerToDelete = _customers.SingleOrDefault(p => p.Id == customer.Id);
            _customers.Remove(customerToDelete);
        }

        public Customer GetById(int id)
        {
            Customer customerToReturn = _customers.SingleOrDefault(p => p.Id == id);
            return customerToReturn;
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            return _customers;
        }

        public void Update(Customer customer)
        {
            Customer customerToUpdate = _customers.SingleOrDefault(p => p.Id == customer.Id);
            customerToUpdate.Name = customer.Name;
            customerToUpdate.Name = customer.LastName;
            customerToUpdate.Id = customer.Id;

        }

        public Customer Get(Expression<Func<Customer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}

