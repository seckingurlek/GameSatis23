using Entity.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Campaign : IEntity
    {
        public double Rate { get; set; }
        public string Name { get; set; }
        public int id { get; set; }
     
    }
}
