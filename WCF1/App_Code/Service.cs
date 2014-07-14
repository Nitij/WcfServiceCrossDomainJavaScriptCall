using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using System.Text;

namespace Microsoft.ServiceModel.Samples
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CalculatorService : ICalculator
    {
        /// <summary>
        /// Add two numbers
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public Double Add(Double n1, Double n2)
        {
            Double result = n1 + n2;

            //Write to the console
            Console.WriteLine("Recieved Add({0} + {1})", n1, n2);
            Console.WriteLine("Result = {0}", result);

            return result;
        }

        /// <summary>
        /// Subtract one number from the other
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public Double Subtract(Double n1, Double n2)
        {
            Double result = n1 - n2;

            //Write to the console
            Console.WriteLine("Recieved Subtract({0} - {1})", n1, n2);
            Console.WriteLine("Result = {0}", result);

            return result;
        }

        /// <summary>
        /// Multiply two numbers
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public Double Multiply(Double n1, Double n2)
        {
            Double result = n1 * n2;

            //Write to the console
            Console.WriteLine("Recieved Multiply({0} * {1})", n1, n2);
            Console.WriteLine("Result = {0}", result);

            return result;
        }

        /// <summary>
        /// Divide two numbers
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public Double Divide(Double n1, Double n2)
        {
            Double result = n1 / n2;

            //Write to the console
            Console.WriteLine("Recieved Divide({0} / {1})", n1, n2);
            Console.WriteLine("Result = {0}", result);

            return result;
        }
    }
}


