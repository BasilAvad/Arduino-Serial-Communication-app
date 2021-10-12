using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace UZTA1.Forms
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 10;
            circularProgressBar2.Value = 2;
            circularProgressBar3.Value = 100;
            circularProgressBar4.Value = 87;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
