﻿using System;
using System.Collections.Generic;
using Heijden.DNS;

namespace DnsTestConsoleApp
{
    public class DnsTest
    {
        private readonly Resolver _resolver;

        public DnsTest()
        {
            _resolver = new Resolver();
            _resolver.Recursion = true;
            _resolver.UseCache = true;
            _resolver.DnsServer = "8.8.8.8"; // Google Public DNS

            _resolver.TimeOut = 1000;
            _resolver.Retries = 3;
            _resolver.TransportType = TransportType.Udp;
        }
        // TXT RECORDS
        public IList<string> TxtRecords(string name)
        {
            IList<string> records = new List<string>();
            const QType qType = QType.TXT;
            const QClass qClass = QClass.IN;

            Response response = _resolver.Query(name, qType, qClass);

            foreach (RecordTXT record in response.RecordsTXT)
            {
                records.Add(record.ToString());
            }

            return records;
        }

        // A RECORDS
        public IList<string> ARecords(string name)
        {
            IList<string> records = new List<string>();
            const QType qType = QType.A;
            const QClass qClass = QClass.IN;

            Response response = _resolver.Query(name, qType, qClass);

            foreach (RecordA record in response.RecordsA)
            {
                records.Add(record.ToString());
            }

            return records;
        }

        // CNAME RECORDS
        public IList<string> CnameRecords(string name)
        {
            IList<string> records = new List<string>();
            const QType qType = QType.CNAME;
            const QClass qClass = QClass.IN;

            Response response = _resolver.Query(name, qType, qClass);

            foreach (RecordCNAME record in response.RecordsCNAME)
            {
                records.Add(record.ToString());
            }

            return records;
        }

        public IList<string> GetQTypes()
        {
            IList<string> items = new List<string>();
            Array types = Enum.GetValues(typeof(QType));

            for (int index = 0; index < types.Length; index++)
            {
                items.Add(types.GetValue(index).ToString());
            }

            return items;
        }

        public IList<string> GetQClasses()
        {
            IList<string> items = new List<string>();
            Array types = Enum.GetValues(typeof(QClass));

            for (int index = 0; index < types.Length; index++)
            {
                items.Add(types.GetValue(index).ToString());
            }

            return items;
        }
    }
}
