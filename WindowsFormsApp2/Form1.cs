using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double d, x1, x2;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);

            d = b * b - 4 * a * c;

            if (a != 0)
            {
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (b + Math.Sqrt(d)) / (2 * a);
                    label4.Text = "X1=" + x1 + ", X2=" + x2;
                }
                else if (d == 0)
                {
                    x1 = -b / (2.0 * a);
                    label4.Text = "Kök=" + x1;
                }
                else
                {
                    label4.Text = "Reel kök yoktur.";
                }
            }
            else
            {
                label4.Text = "A 0 olamaz.";
            }

            // SWITCH KARAR YAPISI
            // koşul veya koşullara göre yapılacak işlemler
            // varsa switch karar yapısını da kullanabiliriz
            // switch karar yapısı şöyledir:
            // switch (ifade)
            // {
            //      case deyimi1:
            //          yapılacak işlemler1;
            //          break;
            //
            //      case deyimi2:
            //          yapılacak işlemler2;
            //          break;
            //
            //      case deyimi3:
            //          yapılacak işlemler3;
            //          break;
            //      ...
            //      ...
            //
            //      default:
            //          yapılacak işlemler;
            //          break;
            // }

            // ifade deyim1'e eşitse yapılacak işlemler1 kısmı yerine getirilir
            // eğer ifade deyim2'e eşitse yapılacak işlemler2 kısmı yerine getirilir
            // ifade deyim3'e eşitse yapılacak işlemler3 kısmı yerine getirilir
            // ifade herhangi bir duruma eşit değilse default kısmı yapılır.

            // break kullanmalıyız aksi halde bir case'den diğer case'e geçtiğimizi
            // düşünüp hata verecektir

            // c#'da switch yapısında bir case'den diğer case'e geçmek istiyorsak bunu
            // goto ile yapmalıyız

            // switch yapısında default kullanmak zorunda değiliz, kullanacağımız zaman da
            // en sonda olması gerekmez



            // FOR DONGÜSÜ

            // for (ifade1; ifade2; ifade3)
            //      işlem veya işlemler

            // ifade1 döngü değişkeninin başlangıç değeridir
            // ifade2 ise koşuldur
            // ifade3 döngü değişkeninin artım miktarıdır
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 12;

           
            switch (a)
            {
                case 2:
                case 25:
                    label4.Text = "A'nın değeri 25 dir.";
                    break;

                case 12:
                    goto case 25;

                default:
                    label4.Text = "A'nın değeri 2, 12, 25 değildir.";
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 4; i++)
            {
                label4.Text = "for döngüsü";
            }
            label4.Text = i.ToString();
        }
    }
}
