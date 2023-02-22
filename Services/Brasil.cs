using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviços_e_entidades.Services
{
    public class Brasil : ICountryTax
    {
        public double TaxCalculator(double amount)
        {
            return 0.20 * amount;
        }
    }
}
