using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace KingCulator
{
    class Summa:ITwoArgumentCalculater
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
