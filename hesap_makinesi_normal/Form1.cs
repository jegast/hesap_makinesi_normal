using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hesap_makinesi_normal
{
    public partial class Form1 : Form
    {
        double say1;
        string opr;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ekran.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
   // fonksiyonu çağıran nesne, uygun forma dönüştürülür, ve işleme sokulur
            Button gelen = (Button)sender;
            if (gelen.Text == "C")
            {
                ekran.Text = "0";
            }
            else if (Char.IsNumber(Convert.ToChar(gelen.Text)))
            {
                ekran.Text += gelen.Text;
            }
            else if (gelen.Text == "=")
            {
                switch (opr)
                {
                    case "+":
                        ekran.Text = (say1 + Convert.ToDouble(ekran.Text)).ToString();
                        break;
                    case "-":
                        ekran.Text = (say1 - Convert.ToDouble(ekran.Text)).ToString();
                        break;
                    case "*":
                        ekran.Text = (say1 * Convert.ToDouble(ekran.Text)).ToString();
                        break;
                    case "/":
                        ekran.Text = (say1 / Convert.ToDouble(ekran.Text)).ToString();
                        break;
                }

            }
            else
            {
                opr = gelen.Text;
                say1 = Convert.ToDouble(ekran.Text);
                ekran.Text = "";
                label1.Text = opr;
            }

        }
    }
}
