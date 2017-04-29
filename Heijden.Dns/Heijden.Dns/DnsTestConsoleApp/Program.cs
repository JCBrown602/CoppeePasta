using System;
using System.Collections.Generic;
/*
 * robertsindall.co.uk
 * 
 * NOTE: domaincontrol.com == Godaddy NS
 * */

namespace DnsTestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Loop indefinitely
            {
                Console.Write("Enter input (Type 'exit' to, you know): "); // Prompt
                string userInput = Console.ReadLine(); // Get string from user
                if (userInput == "exit") // Check string
                {
                    break;
                }
                else
                {
                    Dig newDig = new Dig(userInput);
                }
            }
        }
    }

    class Dig : DnsTest
    {
        #region PROPERTIES
        string _domain;
        DnsTest dnsTest = new DnsTest();

        #endregion

        #region CTORs
        public Dig()
            : this("cnn.com")
        {
            //CTOR Initializer
        }
        public Dig(string domain)
        {
            this._domain = domain;
            string domainWWW = "www." + domain;

            int ARecordCount = dnsTest.ARecords(domain).Count;
            int TXTCount = dnsTest.TxtRecords(domain).Count;
            int TXTCountWWW = dnsTest.TxtRecords(domainWWW).Count;
            int CNameCount = dnsTest.CnameRecords(domainWWW).Count; // No CNAMEs on the naked domain
            int MXCount = dnsTest.MXRecords(domain).Count;
            int NSCount = dnsTest.NSRecords(domain).Count;
        }
        #endregion

        #region GETTERS/SETTERS

        public string Domain { get; set; }

        #endregion

        #region METHODS
        
        public void GetDig(string domainName, DnsTest dnsTest)
        {
            string domainWWW = "www." + domainName;

            int ARecordCount = dnsTest.ARecords(domainName).Count;
            int TXTCount = dnsTest.TxtRecords(domainName).Count;
            int TXTCountWWW = dnsTest.TxtRecords(domainWWW).Count;
            int CNameCount = dnsTest.CnameRecords(domainWWW).Count; // No CNAMEs on the naked domain
            int MXCount = dnsTest.MXRecords(domainName).Count;
            int NSCount = dnsTest.NSRecords(domainName).Count;

            //Console.WriteLine("**************************");
            //Console.WriteLine("*** DOMAIN: {0}", domainName);
            //Console.WriteLine("**************************");

            //Console.WriteLine("> Name Servers: {0}", NSCount);
            //WriteList(dnsTest.NSRecords(domainName), NSCount);

            //Console.WriteLine("> A Records: {0}", ARecordCount);
            //WriteList(dnsTest.ARecords(domainName), ARecordCount);
            
            //Console.WriteLine("> TXT: {0}", TXTCount);
            //WriteList(dnsTest.TxtRecords(domainName), TXTCount);

            //Console.WriteLine("> MX Records: {0}", MXCount);
            //WriteList(dnsTest.MXRecords(domainName), MXCount);

            //Console.WriteLine("**************************");
            //Console.WriteLine("*** DOMAIN: {0}", domainWWW);
            //Console.WriteLine("**************************");

            //Console.WriteLine("***");
            //Console.WriteLine("> A Records: {0}", ARecordCount);
            //WriteList(dnsTest.ARecords(domainWWW));
            //Console.WriteLine("> TXT: {0}", TXTCountWWW);
            //WriteList(dnsTest.TxtRecords(domainWWW), TXTCountWWW);
            //Console.WriteLine("> CNAME: {0}", CNameCount);
            //WriteList(dnsTest.CnameRecords(domainWWW), CNameCount);

            //Console.WriteLine("***");


            ////Console.WriteLine("Available QTypes");
            ////WriteList(dnsTest.GetQTypes());

            ////Console.WriteLine("Available QClasses");
            ////WriteList(dnsTest.GetQClasses());

            //Console.ReadKey();
        }

        private static void WriteList(IEnumerable<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(">\t" + item + " -\t\tItem Length: " + item.Length);
            }
        }

        private static void WriteList(IEnumerable<string> list, int count)
        {
            if (count == 0)
            {
                Console.WriteLine(">\tNONE AVAILABLE.");
            }

            foreach (string item in list)
            {
                if (count == 0)
                {
                    Console.WriteLine(">\tNONE AVAILABLE. ITEM LENGTH: {0}", item.Length);
                    Console.WriteLine(">\tITEM: {0}", item.ToString());
                }
                else
                {
                    Console.WriteLine(">\t" + item + " - \t\tItem Length: " + item.Length);
                }
            }
        }
        #endregion

    }
}
