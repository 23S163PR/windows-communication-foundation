using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace bindings_demo_service_host
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceHost = new ServiceHost(typeof(calculator_service.CalculatorService));
            serviceHost.Open();

            Console.WriteLine("Service started. Press Enter key to exit...");
            Console.ReadLine();

            serviceHost.Close();
        }
    }
}
