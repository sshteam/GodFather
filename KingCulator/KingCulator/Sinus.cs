using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingCulator
{
    class Sinus : IOneArgumentCalculater    {
        public double Calculate(double oneValue)
        {
            return Math.Sin(oneValue);
        }
    }
}
