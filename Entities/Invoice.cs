using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviços_e_entidades.Entities
{
    public class Invoice
    {
        public double Price { get; set; }
        public double Tax { get; set; }
        private double TotalValue { get{ return Price + Tax; } }

        public Invoice(double price, double tax)
        {
            Price = price;
            Tax = tax;
        }
        public override string ToString()
        {
            return $"Price :{Price}" +
                $"\nTax: {Tax}" +
                $"\nTotal: {TotalValue}";
        }
    }
}
