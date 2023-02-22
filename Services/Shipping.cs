using Serviços_e_entidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Serviços_e_entidades.Services
{
    public class Shipping
    {
        public DateTime DeliveryDate { get { return DateTime.Now.AddMonths(1); } }
        
        public ICountryTax CountryTax;
        public double Price { get; set; }

        public Shipping()
        {

        }

        public Shipping(double price,ICountryTax countryTax)
        {
            Price = price;
            CountryTax = countryTax;
        }

        public void ProcessInvoice(Product product)
        {
            double tax = CountryTax.TaxCalculator(Price);

            product._Invoice = new Invoice(Price, tax);
        }
    }
}
