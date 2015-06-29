using calculator_service_client.CalculatorServiceV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace calculator_service_client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new CalculatorService2Client();

            var parrots = client.GetParrots(1);
            Console.WriteLine("1 python equals to {0} parrots according to the service response.", parrots);

            try
            {
                var result = client.GetParrots(-1);
            }
            catch (FaultException<InvalidArguments> e)
            {
                Console.WriteLine("{0}: {1}", e.Detail.ArgumentName, e.Detail.ProblemDescription);
            }

            Console.ReadLine();
            client.Close();
        }
    }
}
