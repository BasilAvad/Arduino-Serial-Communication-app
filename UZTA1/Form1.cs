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
namespace UZTA1
{
    public partial class Form1 : Form
    {
        // Fields
        private Button currentBtton;
        private Random random;
        private int tempIndex;
        private Form activeForm; 
        // Constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // Methods
        private Color SelectColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex==index)
            {
                index= random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender !=null)
            {
                if (currentBtton !=(Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectColor();
                    currentBtton = (Button)btnSender;
                    currentBtton.BackColor = color;
                    currentBtton.ForeColor = Color.White;
                    currentBtton.Font= new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    btnCloseChildForm.Visible = true;

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildeFrom(Form childform, object btn)
        {
            if (activeForm !=null)
            {
                activeForm.Close();
            }
            ActivateButton(btn);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childform);
            this.panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblTitle.Text = childform.Text;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildeFrom(new Forms.FormHome(),sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildeFrom(new Forms.FormAnalytics(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildeFrom(new Forms.FormReportings(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildeFrom(new Forms.FormNotes(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildeFrom(new Forms.FormProducts(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildeFrom(new Forms.FormSettings(), sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm !=null)
            {
                activeForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor=Color.FromArgb(16, 172, 132);
            currentBtton = null;
            btnCloseChildForm.Visible = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
