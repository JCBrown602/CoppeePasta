using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Heijden.DNS;

namespace DNSCP
{
    public class Dig
    {
        private readonly Resolver _resolver;
        private string dnsServer = "8.8.4.4"; // Google public DNS server

        // CTOR
        public Dig()
        {
            _resolver                   = new Resolver();
            _resolver.Recursion         = true;
            _resolver.UseCache          = true;
            _resolver.DnsServer         = dnsServer;

            _resolver.TimeOut           = 1000;
            _resolver.Retries           = 3;
            _resolver.TransportType     = TransportType.Udp;
        }
    }
}
