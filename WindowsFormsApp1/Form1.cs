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

        private void button5_Click(object sender, EventArgs events)
        {
            // Değişkenler

            // Değer tipleri - değişkenin değeri doğrudan bellekte saklanır (stack-yığın)
            // Referans tipler - değişkenin adresi bellekte saklanır, değeri heap-öbek bölgesinde tutulur

            // Değer tipleri
            // byte veri türü
            // 8 bitlik 2^8 = 256
            // 0..255
            //byte a = 2;

            // sbyte veri türü
            // -128..127
            //sbyte b = -26;

            // short veri türü
            // -32768..32767
            //short c = -30000;

            // ushort
            // 0..65535
            //ushort d = 60000;

            // int veri türü
            // -2^31..2^31-1
            //int e = 1243243112;

            // uint veri türü
            // 0..2^32-1

            // long veri türü
            // -2^63..2^63-1

            // ulong veri türü
            // 0..2^64-1

            // float

            // double

            // decimal
            // decimal a = 25.6m;

            // bool

            // char

            // REFERANS TÜRLER

            // string veri türü
            // unicode
            // ""
            //string a = "Görsel";
            //string b = " Programlama 2";
            //string c = a + b;
            //label3.Text = c;

            string dosya = "c:\\okul\\deneme.txt";
            //veya
            string dosya2 = @"c:\okul\deneme.txt";

            //string a = "deneme";
            //int b = 61;
            //label3.Text = a + b.ToString();
            //b = 102;

            // object veri türü
            // csharpta bütün veri türleri gizli olarak objecct veri türünden türer
            // nesneler birer object olduğundan bütün değerler ve nesneler object türünden
            // bir değişkene atanabilir

            //object a;
            //a = 5;
            //label4.Text = a.GetType().ToString();
            //a = 'A';
            //label5.Text = a.GetType().ToString();
            //a = 153.2;
            //label6.Text = a.GetType().ToString();
            //a = true;
            //label7.Text = a.GetType().ToString();
            //a = 46.1351m;
            //label8.Text = a.GetType().ToString();




            // TÜR DÖNÜŞÜMÜ
            // Büyük çaplı projelerde çok fazla değişken kullanılır.
            // Bazen bu değişkenlerle ile işlemler yapmak isteyebiliriz,
            // örneğin int türünden bir sayı ile double türünden bir sayıyı toplamak
            // isteyebiliriz. Bu gibi durumlarda tiplerin uyumlu olabilmesi için
            // tür dönüşümü yapmış oluruz.

            // String bir veri türünü int türde bir veri ile birleştirmek istersek
            // int veri türünü string'e geçici olarak dönüştürürüz.
            // C#'ta tür dönüşümlerini genel olarak 2 alt başlıkta inceleriz.

            // Bunlar; Bilinçiz tür dönüşümü ve bilinçli tür dönüşümüdür.

            // Bilinçiz tür dönüşümü
            // Derleyici tarafından bir değişkenin tanımladığımız tür dışında geçici
            // olarak başka bir türü dönüştürülmesine bilinçsiz tür dönüşümü denir

            //int a = 5;
            //float b = a;

            //float c = 45.2f;
            //int d = c;

            // Bilinçsiz olarak küçük büyüğe dönüşebilir fakat, büyük küçüğe dönüştürülemez
            // Bunun amacı veri kaybını engellemektir.

            //byte a = 12;
            //int b;
            //b = a;
            //label9.Text = b.ToString();

            // Bilinçi tür dönüşümü
            // Genellike derleyicinin izin vermediği durumlarda kullanılır
            // fakat programın anlaşılabilirliğini arttırmak için her durumda bilinçi tür
            // dönüşümünü kullanmamız tavsiye edilir.
            // Bilinçli tür dönüşümünde hem küçüğü büyüğe, hem büyüğü küçüğe dönüştürebiliriz.
            // Tür dönüştürme operatörü olarak parantez kullanılır. ()

            //byte a = 34;
            //int b = (int)a;

            //checked
            //{
            //    int c = 666;
            //    byte d = (byte)c;
            //}


            // checked - unchecked
            // bilinçi dönüşümde veri kaybını önlemek için kullanılır

            // dönüşümü checked bloğunun içinde yaparsak veri kaybı olduğunda bizi uyarır

            //int a = 23;
            //label1.Text = Convert.ToString(a);
            //a = 34;




            // OPERATÖRLER
            // + - * / % ++ --

            //int a = 34;
            //if (a % 2 == 0)
            //    label1.Text = "sayı çifttir";
            //else
            //    label1.Text = "sayı tektir";

            //int a = 29;
            //a = ++a; a yı arttırır sonra atama yapar, a = a + 1
            // a = a++ a yı atadıktan sonra arttırır
            //label1.Text = (++a).ToString();

            // <, >, <=, >=, ==, != eşit değil
            // =, ==
            // || veya, && ve
            // =, +=, -=, *=, /=, %=
            //label1.Text += " giriniz:";

            // () [] ?:
            // koşul ? işlem1 : işlem2

            //int x = 4;
            //string y = "kalem";
            //y = y + (x == 1 ? "" : "ler");
            //label1.Text = y;

            
            //double e = 1d / 2d;
            //label3.Text = e.ToString();




            // KARAR YAPILARI
            // if ve switch
            // if koşul ifadesi
            // if (koşul) yapılacak işlem
        }

        private void button6_Click(object sender, EventArgs e)
        {
            object a;
            a = 5;
            label4.Text = a.GetType().ToString();
            a = 'A';
            label5.Text = a.GetType().ToString();
            a = 153.2;
            label6.Text = a.GetType().ToString();
            a = true;
            label7.Text = a.GetType().ToString();
            a = 46.1351m;
            label8.Text = a.GetType().ToString();
        }
    }
}
