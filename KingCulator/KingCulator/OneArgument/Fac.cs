namespace KingCulator.OneArgument
{
    class Fac : IOneArgumentCalculater
    {
        public double Calculate(double oneValue)
        {
            int fact = 1;

            for (; oneValue > 0; fact *= (int)oneValue--) ;

            return fact;
        }
    }
}
