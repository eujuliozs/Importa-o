using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviços_e_entidades.Services
{
    public interface ICountryTax
    {
        public double TaxCalculator(double amount);
    }
}
