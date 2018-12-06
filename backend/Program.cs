using Nancy.Hosting.Self;
using System;

namespace todolist
{
    class Program
    {
        static void Main()
        {
            var hostConfigs = new HostConfiguration
            {
                UrlReservations = new UrlReservations() { CreateAutomatically = true }
            };

            Uri uri = new Uri("http://localhost:80");
            var host = new NancyHost(hostConfigs, uri);
            host.Start();

            Console.WriteLine("Started");
            Console.Read();
        }
    }
}
