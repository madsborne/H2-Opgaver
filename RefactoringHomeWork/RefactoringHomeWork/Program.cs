using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IpController controller = new IpController();

            Console.WriteLine(controller.HostAdresses());


            Console.WriteLine(controller.LocalPing());
            Console.WriteLine("start");
            Console.WriteLine(controller.HostNameFromIp);
            Console.WriteLine("slut");
            Console.WriteLine("Weee " + controller.IpFromHostName);

            Console.WriteLine("route*** " + controller.TraceRouteDestionation);

            Console.WriteLine(controller.DisplayDhcpServerAddresses());

            Console.ReadKey();
            Console.WriteLine(controller.InfoFromHostName());
            Console.ReadKey();
        }

    }
}

