using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UZTA1.Forms
{
    public partial class FormSettings : Form
    {
        //private cServerClass Server;
        public FormSettings()
        {
            InitializeComponent();
        }

        //private void FormSettings_Load(object sender, EventArgs e)
        //{
        //    string StrIP;
        //    string StringHost;
        //    try
        //    {
        //        StringHost = System.Net.Dns.GetHostName();
        //        StrIP = System.Net.Dns.GetHostByName(StringHost).AddressList[2].ToString();
        //        label2.Text = "Host Name" + StringHost + "IP Adrres" + StrIP;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);

        //    }
        //    Server = new cServerClass();
        //    try
        //    {
        //        richTextBox2.AppendText("-------- Arduino Server Rumming ------");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);

        //    }
        //    Server.Message += RecInfo;
        //}
        //private delegate void UpdateTextBox(RichTextBox richTextBox1, string txt);
        //private void UpdateText(RichTextBox richTextBox1, string txt)
        //{
        //    if (InvokeRequired)
        //    {
        //        richTextBox1.Invoke(new UpdateTextBox(UpdateText), new object[] { richTextBox1, txt });

        //    }
        //    else if (txt != null)
        //    {
        //        richTextBox1.AppendText(txt + "\n");
        //    }
        //}
        //private void RecInfo(cServerClass sender, string data)
        //{
        //    UpdateText(richTextBox2, data);
        //}

        private void FormSettings_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Server.IsListning = false;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            btn_Connect.Enabled = true;
            button_DisConnect.Enabled = false;
            progressBar1.Value = 0;
            System.Object[] ItemObject = new System.Object[5];
            for (int i = 0; i <= 4; i++)
            {
                ItemObject[i] = "9600" + i;
            }
            comboBoxRate.Items.AddRange(ItemObject);
           
        }

        private void comboBoxPort_DropDown(object sender, EventArgs e)
        {
            string[] Portlist = SerialPort.GetPortNames();
            comboBoxPort.Items.Clear();
            comboBoxPort.Items.AddRange(Portlist);
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
