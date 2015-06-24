using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorServiceClient = bindings_demo_service_client.CalculatorServiceV1.CalculatorServiceClient;
using CalculatorService2Client = bindings_demo_service_client.CalculatorServiceV2.CalculatorService2Client;

namespace bindings_demo_service_client
{

    class Program
    {
        const string BasicHttpBindingEndpointName = "basicHttpBinding_CalculatorService";
        const string WSHttpBindingEndpointName = "wsHttpBinding_CalculatorService";
        const string BasicHttpBindingV2EndpointName = "basicHttpBinding_CalculatorServiceV2";

        static void Main(string[] args)
        {
            var basicHttpBindingClient = new CalculatorServiceClient(BasicHttpBindingEndpointName);
            var result = basicHttpBindingClient.GetParrots(1);

            var wsHttpBindingClient = new CalculatorServiceClient(WSHttpBindingEndpointName);
            result = wsHttpBindingClient.GetParrots(1);

            var client2 = new CalculatorService2Client(BasicHttpBindingV2EndpointName);
            var pythons = client2.GetFloatingPointParrots(1.5);
            Console.WriteLine("1.5 pythons = {0:N2} parrots.", pythons);

            Console.ReadLine();
        }
    }
}
