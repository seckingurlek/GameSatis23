using Business.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager:CustomerService
    {
        InMemoryCustomerDal _inMemoryCustomerDal;

        public CustomerManager(InMemoryCustomerDal inMemoryCustomerDal)
        {
            _inMemoryCustomerDal = inMemoryCustomerDal;
        }

        public void AddToBasket(Product product, Customer customer)
        {
            if (customer.basket == null)
            {
                customer.basket = new List<Product>();
            }

            customer.basket.Add(product);
        }
    }
}
