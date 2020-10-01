using FactCalcWebApp.Models;

namespace FactCalcWebApp.Services
{
    /// <summary>
    /// Service used for Factorial of a number using FactModel
    /// </summary>
    public class FactCalcServices : IFactCalcServices
    {
        /// <summary>
        /// Service to Calculate the Factorial
        /// </summary>
        /// <param name="factNumModel">Model having Input Number</param>
        /// <returns>Model with output factorial</returns>
        public FactCalcModel CalculateFactorial(FactCalcModel factNumModel)
        {
            factNumModel.OutputFactNumber = FindFactorial(factNumModel.InputFactNumber);

            return factNumModel;
        }



        /// <summary>
        /// Using Recursion Method we can calculate the Factorial of a given Number
        /// </summary>
        /// <param name="numberToFindFact">Number whose Factorial has to find</param>
        /// <returns>Result as a factorial</returns>
        public double FindFactorial(int numberToFindFact)
        {
            if (numberToFindFact == 1)
                return 1;
            else
                return numberToFindFact * FindFactorial(numberToFindFact - 1);
        }        
    }
}
