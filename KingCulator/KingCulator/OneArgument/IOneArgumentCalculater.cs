namespace KingCulator.OneArgument
{
    /// <summary>
    /// interface of calculator
    /// </summary>
    public interface IOneArgumentCalculater
    {
        /// <summary>
        /// name of calculator
        /// </summary>
        /// <param name="oneValue">name of one argument</param>
        /// <returns>no returned</returns>
        double Calculate(double oneValue);
    }
}