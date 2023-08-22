using Entity.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Sale : IEntity
    {
        public Customer customer { get; set; }
        public List<Product> products { get; set; }
        public double totalprice { get; set; }
    }
}
