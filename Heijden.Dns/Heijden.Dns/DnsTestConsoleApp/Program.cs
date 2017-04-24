using System;
using System.Collections.Generic;
/*
 * robertsindall.co.uk
 * */

namespace DnsTestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DnsTest dnsTest = new DnsTest();
            string domainName = "target.com";
            string domainWWW = "www." + domainName;

            Console.WriteLine("> A Records for: {0}", domainName);
            WriteList(dnsTest.ARecords(domainName));
            Console.WriteLine("> TXT Records for: {0}", domainName);
            WriteList(dnsTest.TxtRecords(domainName));
            Console.WriteLine("> CNAME Records for: {0}", domainName);
            WriteList(dnsTest.CnameRecords(domainName));

            Console.WriteLine("***");
            Console.WriteLine("> A Records for: {0}", domainWWW);
            WriteList(dnsTest.ARecords(domainWWW));
            Console.WriteLine("> TXT Records for: {0}", domainWWW);
            WriteList(dnsTest.TxtRecords(domainWWW));
            Console.WriteLine("> CNAME Records for: {0}", domainWWW);
            WriteList(dnsTest.CnameRecords(domainWWW));

            Console.WriteLine("***");

            //Console.WriteLine("Available QTypes");
            //WriteList(dnsTest.GetQTypes());

            //Console.WriteLine("Available QClasses");
            //WriteList(dnsTest.GetQClasses());

            Console.ReadKey();
        }

        private static void WriteList(IEnumerable<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
