using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace calculator_service
{
    public class CalculatorService : ICalculatorService, ICalculatorService2
    {
        private const int ConversionCoefficientPythonsToParrots = 38;

        public int GetPythons(int parrotsCount)
        {
            ThrowIfArgumentIsLessOrEqualZero(parrotsCount, "parrotsCount");

            return parrotsCount / ConversionCoefficientPythonsToParrots;
        }

        public int GetParrots(int pythonsCount)
        {
            ThrowIfArgumentIsLessOrEqualZero(pythonsCount, "parrotsCount");

            return pythonsCount * ConversionCoefficientPythonsToParrots;
        }

        public double GetPythons(double parrotsCount)
        {
            ThrowIfArgumentIsLessOrEqualZero(parrotsCount, "parrotsCount");

            return parrotsCount / ConversionCoefficientPythonsToParrots;
        }
        
        public double GetParrots(double pythonsCount)
        {
            ThrowIfArgumentIsLessOrEqualZero(pythonsCount, "parrotsCount");

            return pythonsCount * ConversionCoefficientPythonsToParrots;
        }

        private void ThrowIfArgumentIsLessOrEqualZero(double value, string argumentName)
        {
            if (value <= 0)
            {
                var description = new InvalidArguments 
                { 
                    ArgumentName = argumentName,
                    ProblemDescription = "The value cannot be less or equal to zero."
                };

                throw new FaultException<InvalidArguments>(description);
            }
        }
    }
}
