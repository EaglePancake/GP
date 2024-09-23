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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label3.Text = "Tüm alanlar doldurulmalıdır.";
            }
            else
            {
                int s1, s2, sonuc = 0;
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);

                if (radioButton1.Checked)           
                    sonuc = s1 + s2;   
                else if (radioButton2.Checked)     
                    sonuc = s1 - s2;
                else if (radioButton3.Checked)
                    sonuc = s1 * s2;
                else if (radioButton4.Checked)
                    sonuc = s1 / s2;
                else
                {
                    label3.Text = "İşlem seçiniz";
                    return;
                }

                label3.Text = "Sonuç: " + sonuc;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("İlk program!!!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label3.Text = "Tüm alanlar doldurulmalıdır.";
            }
            else
            {
                int s1, s2, sonuc;
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);

                sonuc = s1 + s2;

                label3.Text = "Sonuç: " + sonuc;
            }   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Düzce");
            comboBox1.Items.Add("Çorum");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
