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
    public class ProductManager : ProductService
    {
        InMemoryProductDal _inMemoryProductDal;

        public ProductManager(InMemoryProductDal inMemoryProductDal)
        {
            _inMemoryProductDal = inMemoryProductDal;
        }
         

        public void UpdatePreis(double campaignrate, Product product)
        {
            InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();
            double productpr = inMemoryProductDal.getPrice(product);

            double newproductpr = productpr * campaignrate;
            product.Price = newproductpr;
            
        }
    }
}
