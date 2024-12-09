using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked)
                label3.Text = topla(s1, s2).ToString();
            else if (radioButton2.Checked)
                label3.Text = cikar(s1, s2).ToString();
            else if (radioButton3.Checked)
                label3.Text = carp(s1, s2).ToString();
            else if (radioButton4.Checked)
            {
                if (s2 == 0)
                    label3.Text = "Sıfıra bölme yapılamaz.";
                else
                    label3.Text = bol(s1, s2).ToString();
            }
            else
                label3.Text = "Seçim yapınız.";
        }

        double topla(double a, double b)
        {
            return a + b;
        }

        double cikar(double a, double b)
        {
            return a - b;
        }

        double carp(double a, double b)
        {
            return a * b;
        }

        double bol(double a, double b)
        {
            return a / b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBox3.Text);
            int i;
            for (i = 1; i <= n; i++)
            {
                int sonuc = faktoriyel(i);
                listBox1.Items.Add(i + " != " + sonuc);
                
            }

        }

        // 1 den n ye kadar olan sayıların faktoriyelini hesaplayan VC# programı
        int faktoriyel(int n)
        {
            int carp = 1;
            for (int i = 1; i <= n; i++)
            {
                carp *= i;
            }
            return carp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n, m;
            double sonuc;
            n = Convert.ToInt32(textBox3.Text);
            m = Convert.ToInt32(textBox4.Text);

            if (m <= n)
            {
                sonuc = faktoriyel(n) / (faktoriyel(m) * faktoriyel(n - m));
                label3.Text = n + " nin " + m + " li kombinasyonu = " + sonuc;
            }
            else
                label3.Text = "m, n den küçük veya eşit olmalıdır.";
        }

        double f(double n)
        {
            return n*n + n + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox5.Text);
            double n = Convert.ToInt32(textBox6.Text);
            double fonk_sonuc = x;
            for (int i = 1; i <= n; i++)
            {
                fonk_sonuc = f(fonk_sonuc);
            }
            label3.Text = fonk_sonuc.ToString();
        }
    }
}
