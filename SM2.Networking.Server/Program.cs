using System;
using System.Net;

namespace SM2.Core.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new ServerWrapper(new IPEndPoint(IPAddress.Any, 25565));
            server.Start();
            server.RunToComplete().Wait();
            Console.ReadLine();
        }
    }
}
