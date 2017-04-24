using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ARSoft.Tools.Net;
using ARSoft.Tools.Net.Dns;
using System.Net;

/* need to see "we are the millers" ~James
 * burpsuite
 * what is our privacy/data storage
 * security+
 * hak5, threatwire - youtubes
*/

namespace BatSite31
{
    public partial class Form1 : Form
    {
        private DateTime currentTime = DateTime.UtcNow;
        private DateTime timeStamp = DateTime.UtcNow;
        private string currentTimeStr = DateTime.UtcNow.ToString();
        private string currentToon = "";
        private bool nameSet = false;

        public Form1()
        {
            InitializeComponent();
            timerRefresh.Start();
            PasteData();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        private void SetToClipboard(object text)
        {
            Clipboard.SetDataObject(text);
        }

        private void PasteData()
        {
            //string ClipData = Clipboard.GetText();
            IDataObject ClipData = Clipboard.GetDataObject();
            timerRefresh.Start();

            if (ClipData.GetDataPresent(DataFormats.Text))
            {
                currentToon = currentToonText.Text;
                string s = Clipboard.GetData(DataFormats.Text).ToString();
                //s = StringTool.Truncate(s, 3);
                string t = StringTool.Truncate(labelClip.Text, 3);
                if (t != s)
                {
                    labelClip.Text = s + " - " + setTimeStamp(currentTime) + " - " + currentToon;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetName()
        {
            IDataObject ClipData = Clipboard.GetDataObject();
            timerRefresh.Start();
            if (ClipData.GetDataPresent(DataFormats.Text))
            {
                string s = Clipboard.GetData(DataFormats.Text).ToString();
                //s = s.Substring(0, 3) + " - ";
                currentToonText.Text = StringTool.Truncate(s, 25);
            }
            nameSet = true;
        }

        
        private void getMXrecords()
        {
            // Uses same Google DNS server as DigWebInterface
            IPAddress dnsServerAddress = IPAddress.Parse("8.8.4.4");
            string[] hostname = {"sitelock","com"};
            DomainName domainName = new DomainName(hostname);

            var response = DnsClient.Default.Resolve(domainName, RecordType.Mx);
            var mxRecords = response.AnswerRecords.OfType<MxRecord>();

            foreach (MxRecord record in mxRecords)
            {
                MXrecListBox.Items.Add(record);
                richTextBox1.AppendText(record.ToString());
                richTextBox1.AppendText("\n");
            }

        }

        private void getArecordsCNN()
        {
            string hostname = "sitelock.com";
            IPAddress[] host;
            host = Dns.GetHostAddresses(hostname);
            List<string> txtBoxList = new List<string>();

            foreach (IPAddress ip in host)
            {
                MXrecListBox.Items.Add(ip);
                richTextBox1.AppendText(ip.ToString());
                richTextBox1.AppendText("\n");
            }
        }

        private void getArecords()
        {
            string hostname = "google.com";
            IPHostEntry host;
            host = Dns.GetHostEntry(hostname);

            foreach (IPAddress ip in host.AddressList)
            {
                MXrecListBox.Items.Add(ip);
            }
        }
        // BUTTONSET
        private void buttonSet_Click_1(object sender, EventArgs e)
        {
            nameSet = false;
            SetName();
            getArecordsCNN();
            getMXrecords();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            //nameSet = !nameSet;
            //SetToClipboard(textClip.Text);
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            //PasteData();
        }

        private void timerRefresh_Tick_1(object sender, EventArgs e)
        {
            PasteData();
            setTime();
        }

        private void setTime()
        {
            currentTime = DateTime.UtcNow;
            currentTimeStr = String.Format("{0:T}", currentTime);
            label1.Text = currentTimeStr;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = currentTime.ToString();
        }

        private void timeBtn_Click(object sender, EventArgs e)
        {
            labelClip.Text = String.Format("{0:T}", currentTime);
        }

        private string setTimeStamp(DateTime cTime)
        {
            string time = String.Format("{0:t}", cTime);
            return time;
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

    public static class StringTool
    {
        public static string Truncate(string source, int length)
        {
            if (source.Length > length)
            {
                source = source.Substring(0, length);
            }
            return source;
        }
    }
}
