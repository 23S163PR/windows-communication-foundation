using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_service
{
    public class CalculatorService : ICalculatorService, ICalculatorService2
    {
        private const int ConversionCoefficientPythonsToParrots = 38;

        public int GetPythons(int parrotsCount)
        {
            return parrotsCount / ConversionCoefficientPythonsToParrots;
        }

        public int GetParrots(int pythonsCount)
        {
            return pythonsCount * ConversionCoefficientPythonsToParrots;
        }

        public double GetPythons(double parrotsCount)
        {
            return parrotsCount / ConversionCoefficientPythonsToParrots;
        }

        public double GetParrots(double pythonsCount)
        {
            return pythonsCount * ConversionCoefficientPythonsToParrots;
        }
    }
}
