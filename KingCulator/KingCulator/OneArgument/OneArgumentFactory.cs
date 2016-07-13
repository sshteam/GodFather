using System;

namespace KingCulator.OneArgument
{
     public static class OneArgumentFactory
    {
         /// <summary>
         /// to count fuctions with one argument
         /// </summary>
         /// <param name="calculatorName">name of calculator</param>
         /// <returns>return value of the function</returns>
         public static IOneArgumentCalculater CreateCalculater(string calculatorName)
         {
             switch (calculatorName)
             {
                 case "sin": return new Sinus();
                 case "cos": return new Cosinus();
                 case "tg": return new Tangens();
                 case "arctg": return new ArcTangens();
                 case "ln": return new Ln();
                 case "sqrt": return new Sqrt();
                 case "arccos": return new Arccos();
                 case "arcsin": return new Arcsin();
                 case "factorial": return new Fac();
                 case "exp": return new Exp();
                 default:
                     throw new Exception("Неизвестная опереация");
             }
         }
    }
}
