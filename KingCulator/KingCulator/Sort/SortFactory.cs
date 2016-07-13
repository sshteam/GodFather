using System;

namespace KingCulator.Sort
{
    public static class SortFactory
    {
        public static ISorter CreateCalculater(string calculatorName)
        {
            switch (calculatorName)
            {
                case "sort1": return new Choose();
                case "sort2": return new QuickSort();
                default:
                    throw new Exception("Неизвестная опереация");
            }
        }   
    }
}