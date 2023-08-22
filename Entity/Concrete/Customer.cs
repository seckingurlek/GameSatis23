using Entity.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get;set; }

        public List<Product> basket { get; set; }
    }
}
