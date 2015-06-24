using calculator_service_client.CalculatorServiceV1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_service_client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new CalculatorServiceClient();

            var parrots = client.GetParrots(1);
            Console.WriteLine("1 python equals to {0} parrots according to the service response.", parrots);
            Console.ReadLine();
        }
    }
}
