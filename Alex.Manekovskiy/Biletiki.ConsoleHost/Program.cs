using Biletiki.Contracts.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Biletiki.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(BiletikiService));
            host.Open();

            Console.WriteLine("Service started. Press Enter key to exit...");
            Console.ReadLine();

            host.Close();
        }
    }
}
