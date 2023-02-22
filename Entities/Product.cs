using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviços_e_entidades.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public Invoice _Invoice { get; set; }

        public Product()
        {

        }
        public Product(string name)
        {
            Name = name;

        }
    }
}
