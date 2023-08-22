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
    public class InMemoryProductDal : IProduct
    {


        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
             {
                 new Product{Id = 1, Name ="Fifa", Price= 20},
                 new Product{Id = 2, Name ="Gta", Price= 10},
                 new Product{Id = 3, Name ="Valorant", Price= 40}
             };   
        }    
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=> p.Id == product.Id);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }


        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;
            productToUpdate.Id = product.Id;
        }
        

        public Product GetByIdProduct(int id)
        {
            Product product = _products.FirstOrDefault(p => p.Id == id);
            return product;
        }
        public double getPrice(Product product) 
        {
            return product.Price;
        }
        }
    

    }

    
