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
    class IpController
    {
        private string hostNameFromIp;
        private string ipFromHostName;
        private string traceRouteDestionation;

        public string HostNameFromIp
        {
            get { return hostNameFromIp; }
            set { hostNameFromIp = value; }
        }

        public string IpFromHostName
        {
            get { return ipFromHostName; }
            set { ipFromHostName = value; }
        }

        public string TraceRouteDestionation
        {
            get { return traceRouteDestionation; }
            set { traceRouteDestionation = value; }
        }

        public IpController()
        {
            TraceRouteDestionation = Traceroute("8.8.8.8");
            HostNameFromIp = GetHostnameFromIp("8.8.8.8");
            IpFromHostName = GetIpFromHostname(HostNameFromIp);
        }


        public string LocalPing()
        {
            // Local vars
            string localPingResult;

            // Ping's the local machine.
            Ping pingSender = new Ping();
            IPAddress address = IPAddress.Loopback;
            PingReply reply = pingSender.Send(address);

            if (reply.Status == IPStatus.Success)
            {
                localPingResult = $"Address: {reply.Address.ToString()}\r\n" +
                         $"RoundTrip time: {reply.RoundtripTime}\r\n" +
                         $"Time to live: {reply.Options.Ttl}\r\n" +
                         $"Don't fragment: {reply.Options.DontFragment}\r\n" +
                         $"Buffer size: {reply.Buffer.Length}\r\n";

                return localPingResult;
            }
            else
            {
                return $"{reply.Status}";
            }
        }

        private string Traceroute(string ipAddressOrHostName)
        {
            IPAddress ipAddress = Dns.GetHostEntry(ipAddressOrHostName).AddressList[0];
            StringBuilder traceResults = new StringBuilder();


            using (Ping pingSender = new Ping())
            {

                PingOptions pingOptions = new PingOptions();
                Stopwatch stopWatch = new Stopwatch();
                byte[] bytes = new byte[32];

                pingOptions.DontFragment = true;
                pingOptions.Ttl = 1;
                int maxHops = 30;

                traceResults.AppendLine(
                    string.Format(
                        "Tracing route to {0} over a maximum of {1} hops:",
                        ipAddress,
                        maxHops));

                traceResults.AppendLine();

                for (int i = 1; i < maxHops + 1; i++)
                {
                    stopWatch.Reset();
                    stopWatch.Start();

                    PingReply pingReply = pingSender.Send(
                        ipAddress,
                        5000,
                        new byte[32], pingOptions);

                    stopWatch.Stop();

                    traceResults.AppendLine(
                        string.Format("{0}\t{1} ms\t{2}",
                        i,
                        stopWatch.ElapsedMilliseconds,
                        pingReply.Address));



                    if (pingReply.Status == IPStatus.Success)
                    {
                        traceResults.AppendLine();
                        traceResults.AppendLine("Trace complete."); break;
                    }

                    pingOptions.Ttl++;

                }
            }
            return traceResults.ToString();
        }

        private string GetHostnameFromIp(string Ip)
        {
            string hostname = "";
            try
            {
                IPHostEntry ipHostEntry = Dns.GetHostEntry(Ip);
                hostname = ipHostEntry.HostName;
            }
            catch (FormatException)
            {
                hostname = "Please specify a valid IP address.";
                return hostname;
            }
            catch (SocketException)
            {
                hostname = "Unable to perform lookup - a socket error occured.";
                return hostname;
            }
            catch (SecurityException)
            {
                hostname = "Unable to perform lookup - permission denied.";
                return hostname;
            }
            catch (Exception)
            {
                hostname = "An unspecified error occured.";
                return hostname;
            }

            return hostname;
        }

        private string GetIpFromHostname(string Hostname)
        {
            string ip = "";
            try
            {
                IPHostEntry ipHostEntry = Dns.GetHostEntry(Hostname);
                if (ipHostEntry.AddressList.Length > 0)
                {
                    ip = ipHostEntry.AddressList[0].ToString();
                }
                else
                {
                    ip = "No information found.";
                }
            }
            catch (SocketException)
            {
                ip = "Unable to perform lookup - a socket error occured.";
                return ip;
            }
            catch (SecurityException)
            {
                ip = "Unable to perform lookup - permission denied.";
                return ip;
            }
            catch (Exception)
            {
                ip = "An unspecified error occured.";
                return ip;
            }

            return ip;
        }

        public string InfoFromHostName()
        {
            //WIN-M69SG2Q0732.test.local
            //ZBC-RG01203MKC
            // My Pc -> DESKTOP-ISJG5JV
            string hostName = "DESKTOP-ISJG5JV";
            string infoFromHostNameResult;
            IPHostEntry hostInfo = Dns.GetHostEntry(hostName);

            // Get the IP address list that resolves to the host names contained in the 
            // Alias property.
            IPAddress[] address = hostInfo.AddressList;

            // Get the alias names of the addresses in the IP address list.
            String[] alias = hostInfo.Aliases;

            try
            {
                infoFromHostNameResult = $"Host name : {hostInfo.HostName} " + "\nAliases : ";
                for (int index = 0; index < alias.Length; index++)
                {
                    infoFromHostNameResult += $"\n{alias[index]}";
                }

                infoFromHostNameResult += "\nIP address list : ";
                for (int index = 0; index < address.Length; index++)
                {
                    infoFromHostNameResult += $"\n{address[index]}";
                }
                return infoFromHostNameResult;
            }
            catch (Exception e)
            {
                return e.Message;
            }


        }

        public string DisplayDhcpServerAddresses()
        {
            string displayDhcpServerAddressResult;

            displayDhcpServerAddressResult = "DHCP Servers";
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties adapteradapterProperties = adapter.GetIPProperties();
                IPAddressCollection addresses = adapteradapterProperties.DhcpServerAddresses;
                if (addresses.Count > 0)
                {
                    displayDhcpServerAddressResult += $"\n{adapter.Description}";
                    foreach (IPAddress address in addresses)
                    {
                        displayDhcpServerAddressResult += $"\nDhcp Address ............................ : {address.ToString()}";
                    }
                }
            }
            return displayDhcpServerAddressResult;
        }

        public string HostAdresses()
        {
            string hostAdressesResult = "";
            IPAddress[] array = Dns.GetHostAddresses("en.wikipedia.org");
            foreach (IPAddress ip in array)
            {
                hostAdressesResult += $"Ip from wikipedia -> {ip.ToString()}\n";
            }

            return hostAdressesResult;
        }
    }
}
