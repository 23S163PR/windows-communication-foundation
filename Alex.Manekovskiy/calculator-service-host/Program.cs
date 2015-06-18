using calculator_service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace calculator_service_host
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = new Uri("http://localhost:1337/calculator");

            var serviceHost = new ServiceHost(typeof(CalculatorService), baseAddress);

            var metadataBehavior = new ServiceMetadataBehavior();
            metadataBehavior.HttpGetEnabled = true;

            serviceHost.Description.Behaviors.Add(metadataBehavior);

            serviceHost.Open();

            Console.WriteLine("Service started. Press Enter key to stop...");
            Console.ReadLine();

            serviceHost.Close();
        }
    }
}
