using System;
using System.ServiceModel;
using wcf_cinema_service;

namespace service_host
{
    static class Program
    {
        static void Main(string[] args)
        {
            var serviceHost = new ServiceHost(typeof(CinemaService));
            serviceHost.Open();
            Console.WriteLine("Service started. Press Enter key to exit...");
            Console.ReadLine();

            serviceHost.Close();
        }
    }
}
