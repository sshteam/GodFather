﻿using System;

namespace KingCulator.TwoArgument
{
   public static class TwoArgumentFactory
   {
       public static ITwoArgumentCalculater CreateCalculater(string calculatorName)
       {
           switch (calculatorName)
           {
               case "summa": return new Summa();
               case "minus": return new Minus();
               case "umnozenie": return new Umnozenie();
               case "delenie": return new Delenie();
               case "power": return new Power();
               case "log": return new Log();
               default:
                   throw new Exception("Неизвестная опереация");
           }
       }
   }
}
