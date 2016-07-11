using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingCulator
{
   public static class TwoArgumentFabric
   {
       public static ITwoArgumentCalculater CreateCalculater(string calculatorName)
       {
           switch (calculatorName)
           {
               case "summa": return new Summa();
               case "minus": return new Minus();
               case "umnozenie": return new Umnozenie();
               case "delenie": return new Delenie();
               default:
                   throw new Exception("Неизвестная опереация");
           }
       }
   }
}
