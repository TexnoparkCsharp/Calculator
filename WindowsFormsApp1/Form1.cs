using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton5.Text;
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton6.Text;
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton7.Text;
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton9.Text;
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton10.Text;
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton11.Text;
        }

        private void guna2GradientButton13_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton13.Text;
        }

        private void guna2GradientButton14_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton14.Text;
        }

        private void guna2GradientButton15_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton15.Text;
        }

        private void guna2GradientButton17_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton17.Text;
        }

        private void guna2GradientButton18_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton18.Text;
        }

        private void guna2GradientButton19_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton19.Text;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton1.Text;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton2.Text;
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton3.Text;
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton4.Text;
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            txt_ekran.Text += guna2GradientButton8.Text;
        }

        private void guna2GradientButton16_Click(object sender, EventArgs e)
        {
            txt_ekran.Text = "";
        }

        private void guna2GradientButton20_Click(object sender, EventArgs e)
        {
            var result = new DataTable().Compute(txt_ekran.Text, null);
            txt_ekran.Text = result.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
