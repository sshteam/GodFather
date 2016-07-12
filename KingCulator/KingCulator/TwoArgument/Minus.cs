namespace KingCulator.TwoArgument
{
    public class Minus:ITwoArgumentCalculater
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
