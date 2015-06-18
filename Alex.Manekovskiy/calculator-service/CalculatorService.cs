using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_service
{
    public class CalculatorService : ICalculatorService
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
    }
}
