using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviços_e_entidades.Services
{
    class Portugal : ICountryTax
    {
        public double TaxCalculator(double Amount)
        {
            return 0.10 * Amount;
        }
    }
}
