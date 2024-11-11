using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 25;
            a /= 2;
            label1.Text = a.ToString();

            return;
            int x = 20;
            switch (x % 4)
            {
                case 2:
                case 1:
                    label1.Text = "ara sınav"; break;
                case 3:
                    label1.Text = "matematik"; break;
                default:
                    label1.Text = "bilgisayar";
                    goto case 2;
            }

            return;

            double toplam1 = 0;
            double n = 10;
            for(double i = 1; i <= n; i++)
            {
                double toplam2 = 0;
                for (double j = 1; j <= i; j++)
                {
                    toplam2 += Math.Pow(i, j) + Math.Pow(j, i);
                }
                toplam1 += toplam2;
            }

            label1.Text = toplam1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double sonuc = 0;
            if (x > 1)
            {
                sonuc = Math.Pow(Math.E, x) / (x + 1);
            }
            else if (x > 0 && x <= 1)
            {
                sonuc = Math.PI * x / 5;
            }
            else
            {
                sonuc = Math.Sqrt(Math.Cos(x));
            }
            label2.Text = sonuc.ToString();
        }

        void a()
        {
            
        }
    }
}
