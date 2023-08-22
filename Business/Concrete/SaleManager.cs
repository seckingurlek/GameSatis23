using Business.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SaleManager : SaleService
    {
        InMemorySaleDal _inMemorySaleDal;

        public SaleManager(InMemorySaleDal inMemorySaleDal)
        {
            _inMemorySaleDal = inMemorySaleDal;
        }



        public Sale CustomerBuy(Customer customer)
        {

            Sale sale = new Sale { products = customer.basket, customer = customer};
            double totalpriceproducts = 0;
            foreach (Product product in customer.basket) 
            {
                totalpriceproducts = totalpriceproducts + product.Price;
                sale.totalprice = totalpriceproducts;
            }

            
            _inMemorySaleDal.Add(sale);
            return sale;
        }
    }
}
