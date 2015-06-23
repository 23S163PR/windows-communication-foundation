using bindings_demo_service_client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bindings_demo_service_client
{

    class Program
    {
        const string BasicHttpBindingEndpointName = "basicHttpBinding_CalculatorService";
        const string WSHttpBindingEndpointName = "wsHttpBinding_CalculatorService";

        static void Main(string[] args)
        {
            var basicHttpBindingClient = new CalculatorServiceClient(BasicHttpBindingEndpointName);
            var result = basicHttpBindingClient.GetParrots(1);

            Console.ReadLine();

            var wsHttpBindingClient = new CalculatorServiceClient(WSHttpBindingEndpointName);
            result = wsHttpBindingClient.GetParrots(1);

            Console.ReadLine();
        }
    }
}
