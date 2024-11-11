using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //OPERATÖRLER
            // + - * / % ++ -- 
            // % ; mod 
            // ++ ; bir arttırmak
            // -- ; bir eksiltmek
            //int a = 34;
            //if (a % 2 == 0)
            //     label1.Text = "Sayı çifttir";
            // else
            //     label1.Text = "Sayı tektir";
            //int a = 29;
            //a = ++a; a++ a=a+1
            //a = a++; 
            //label1.Text = (++a).ToString();
            // Karşılaştırma operatörleri
            // <, >, <=, >=, ==, !=
            //if (a % 2 != 0)
            //     label1.Text = "Sayı tektir";
            // else
            //     label1.Text = "Sayı çifttir";
            // Mantıksal operatörler
            // || veya ,&& ve // or ve and yoktur
            // Atama operatörleri
            // =, +=, -=, *=, /=, %=
            // a = 2;
            // a += 6; a = a + 6
            // a -= 8; a = a - 8
            // a *= 5; a = a * 5
            //label1.Text = "Sayı 1 ";
            //label1.Text += " giriniz: ";

            // () ; Tür dönüşümü veya method çalıştırmak için
            // [] ; Dizilerde kullanılır
            // ? ; koşul?işlem1:işlem2 koşul sağlanıyorsa işlem1 şağlanmıyorsa işlem2 yapar

            //int x = 4;
            //string y = "kalem";
            //y = y + (x==1?"":"ler");
            //label1.Text = y;

            int a = 1 + 2 * 4 / 2 + (3 - 2 * (3 + 5));
            label1.Text = a.ToString();
            //int b = 1 / 3;
            //label2.Text = b.ToString(); // b int olduğu için tam kısmmını alır
            // double c = 1 / 2; // 2 tamsayı birbirine bölünürse sonuçta tamsayı olur  
            //double c = 1.0 / 2.0;
            //label3.Text = c.ToString();
            //int d = (int)(1 / 2.0);
            //label4.Text = d.ToString();
            double f = Math.Pow(5, 3); // pow işleminin sonucu ondalıklı çıkar
            label2.Text = f.ToString();
            // Karar Yapıları
            // Bazen program yazarken belli bir koşula göre işlem yapmak isteyebiliriz. Örneğin bir sayı sıfırdan büyyükken
            // farklı bir işlem sıfırdan küçükkken farklı bir işlem yapmak isteyebiliriz. Bu gibi durumlarda
            // c# ta kullanabileceğimiz 2 koşul ifadesi vardır. Bunlar if ve switch yapılarıdır. Bu koşul ifadelerini birbirlerinin
            // yerlerine kullanabiliriz bazı durumlarda programın okunabilirliğini arttırmak için switch koşul ifadesini tercih edebiliriz. 
            // if koşul ifadesi
            // if koşul ifadesinin kullanımı şu şekildedir.
            // if (koşul) yapılacak işlem
            //int sayi = 61;
            //if (sayi >= 61); MessageBox.Show("Sayı uygun değil");

            // if (koşul1)
            // {
            // koşul1 sağlanınca yapılacak işlemler
            // }
            // else if (koşul 2)
            // {
            // koşul2 sağlanınca yapılacak işlemler
            // }
            // else i
            // {
            // koşullar sağlanmayınca yapılacak işlemler
            // }
            int sayi = 61;
            if (sayi % 2 != 0)
            {
                sayi = sayi * sayi;
                label3.Text = sayi.ToString();
            }
            else
            {
                label3.Text = "Sayı Çifttir";
            }
            double sayi2 = 0;
            double sonuc;
            if (sayi2 > 0) 
            {
                sonuc = Math.Pow(sayi2, 3);
                //label3.Text = sonuc.ToString();
            }
            else if (sayi2 == 0)
            {
                sonuc = Math.Cos(Math.PI / 3);
                //label3.Text = sonuc.ToString();
            }
            else
            {
                sonuc = Math.Abs(sayi2);
                //label3.Text = sonuc.ToString();
            }
            label3.Text = sonuc.ToString();
            int a1 = 5,c = 5 ;// girilen bir denklemin kökleri bulan kodu yazınız if kullanarak
            double b = 3;
            if (Math.Pow(b, 2) - (4 * a1 * c) > 0)
            { 
            }
            else if (Math.Pow(b, 2) - (4 * a1 * c) == 0) 
            { 
            
            }
            else 
        }    


    }
}
