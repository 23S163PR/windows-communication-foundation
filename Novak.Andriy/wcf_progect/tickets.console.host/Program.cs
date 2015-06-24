using System;
using System.ServiceModel;
using tickets.contracts.impl;

namespace tickets.console.host
{
    static class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(TicketService));
            host.Open();
            Console.WriteLine("Service started. Press Enter key to exit...");
            Console.ReadLine();

            host.Close();
        }
    }
}
