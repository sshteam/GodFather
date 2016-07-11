using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingCulator
{
     public static class OneArgumentFactory
    {
         public static IOneArgumentCalculater CreateCalculater(string calculatorName)
         {
             switch (calculatorName)
             {
                 case "sin": return new Sinus();
                 case "cos": return new Cosinus();
                 case "tg": return new Tangens();
                 case "arctg": return new ArcTangens();
                 default:
                     throw new Exception("Неизвестная опереация");
             }
         }
    }
}
