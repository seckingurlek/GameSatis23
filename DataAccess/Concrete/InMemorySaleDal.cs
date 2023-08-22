using DataAccess.Abstarct;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class InMemorySaleDal : ISale
    {
        private List<Sale> _sales;

        public InMemorySaleDal(InMemoryCustomerDal inMemoryCustomerDal, InMemoryProductDal inMemoryProductDal)
        {
            _sales = new List<Sale>();
        }

        public void Add(Sale sale)
        {
            _sales.Add(sale);
        }

        public void Delete(Sale sale)
        {
            throw new NotImplementedException();
        }

        public Sale Get(Expression<Func<Sale, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetAll(Expression<Func<Sale, bool>> filter = null)
        {
            return _sales;
        }

        public void Update(Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
