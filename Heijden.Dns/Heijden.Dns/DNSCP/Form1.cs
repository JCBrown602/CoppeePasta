using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnsTestConsoleApp; // Gets/formats DNS Records

using DnsTestConsoleApp;

namespace DNSCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void domainBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void getRecordsBtn_Click(object sender, EventArgs e)
        {
            DnsTest newDNS = new DnsTest();

            richTextBox1.Text = newDNS.ARecords(domainBox.Text).ToString();
        }



    }
}
