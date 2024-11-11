using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    label4.Text = "Kök 1=" + x1 + ",Kök 2 =" + x2;
                }
                else if (d == 0)
                {
                    x1 = -b / (2 * a);
                    label4.Text = "Kök =" + x1;
                }
                else
                    label4.Text = "REEL KÖK YOKTUR";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //switch karar yapısı
        // koşul veya koşullara göre yapılacak işlem veya işlemler varsa switch karar yapısında kullanabiliriz.
        // switch karar yapısı şöyledir;
        // switch (İfade)
        // {
        // case deyim1:
        // yapılacak işlemler1;
        // break;
        // case deyim2:
        // yapılacak işlemler2;
        // break;

        // case deyim3:
        // yapılacak işlemler3;
        // break;
        // ...
        // default:
        // yapılacak işlemler;
        // break;
        // }
        // İfade deyim1 eşitse yapılacak işlemler 1 kısmı yerine getirilir.
        // Eğer ifade deyim2 ye eşitse yapılacak işlemler 2 kısmı yerine getirilir.
        // Eğer ifade deyim3 e eşitse yapılacak işlemler 3 kısmı yerine getirilir.
        // ifade herhangi bir duruma eşit değilse default kısmı yapılır.
        // switch yapısında her durumdan sonra break kullanmak zorundayız.
        // Aksi halde bir caseden diğer case e geçtiğimizi düşünüp hata verecektir.
        // C# ta switch yapısında bir caseden diğer case e geçmek istiyorsak bunu goto ile yapmalıyız.
        // switch yapısında default kullanmak zorunda değiliz.
        // Kullancağımız zamanda en sonda olması gerekmez.
        private void button3_Click(object sender, EventArgs e)
        {
            int a = 25;
            switch (a)
            {
                case 2:
                    label4.Text = "a nın değeri 2 dir";
                    break;

                case 25:
                    label4.Text = "a nın değeri 25 dir";
                    break;
                case 12:
                    label4.Text = "a nın değeri 12 dir";
                    break;
                default:
                    label4.Text = "a nın değeri 2,12,25 değildir";
                    break;
            }
        }
        //int a = 25;
        //switch (a)
        //{
        //case 2:
        //case 25:
        //label4.Text = "a nın değeri 2 veya 25 dir";
        //break;
        //case 12:
        //goto case 25;
        //default:
        //label4.Text = "a nın değeri 2,12,25 değildir";
        //break;
        //}

        //int a = 25;
        //switch (a)
        //{
        //case 2:
        //case 25:
        //label4.Text = "a nın değeri 2 veya 25 dir";
        //break;
        //case 12:
        //label4.Text = "a nın değeri 12 dir";
        //break;
        //default:
        //label4.Text = "a nın değeri 2,12,25 değildir";
        //break;
        //}






        // DÖNGÜLER :
        // Program yazarken bir koşul veya koşullara göre tekrar tekrar yapmamız gereken kısımlar olabilir.
        // Bu gibi durumlarda döngüleri kullanırız örneğin girilen n tane sayıyı toplamak istiyosak
        // Döngülerden yararlanabiliriz c# kullanabileceğimiz 4 döngü yapısı vardır.
        // Bunlar for ,while, dowhile, foreach bu dört döngüyü birbiri yerine kullabnabiliriz.
        // For Döngüsü:
        //// for döngüsünün yapısı şöyledir.
        //// for (ifade1;ifade2;ifade3)
        //// işlem veya işlemler 
        // Burada ifade1 döngü değişkeninin başlangıç değeridir. İfade 2 ise koşuldur.ifade 3 döngü değişkeninin artım değeridir.döngü şu şekilde çalışır
        // İfade 1 yani döngü değişkeninin başlangıç değeri ifade 2 yani koşulu sağlıyosa
        // İşlem veya işlemler yapılır. ardından ifade 3 e gelinir. İfade 3 te döngü değişkeni artırılır veya azaltılır.
        // Ardından tekrar ifade 2 ye bakılır. İfade 2 sağlanıyorsa döngü işlemi tekrar yapılır.
        // Bu şekilde devam edilir.
        // son olarak ifade 2 sağlanmadığında döngü yapısındamn çıkılır.
        // for döngüsünde 2 ; olmak zorundadır bunun dışında ifade1,ifade2,ifade3 döngüde olmayabilir.
        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 4; i++)
            {
                label4.Text += "for döngüsü";
                //label4.Text = i.ToString(); 
            }
            label4.Text = i.ToString();
            int i1 = 1;
            for (; i1 <= 4;)//sonsuz döngü
            {
                label4.Text += "for döngüsü" + i + "\n";
                //label4.Text = i1.ToString(); 
            }
            //label4 4 kez for döngüsü yazmış olur döngüden çıkarken i nin değeri 5 olur. 
            ///// Döngü bitince sayı artar.###
            // int i=0,j=0;
            //double d = 34 
            //label4.Text = ""
            //for (i = 1; i <= 5, i++)
            //{ for (j = 1; j <= 4, j++)
            //    {label4.Text = "TOPLAM" i+j } 
            //}

            // break , continue 
            // break döngü içinde breakle karşılaşınca döngü kırılır yani sonlanır
            // continue ise döngünün bir sonraki değerine geçer.
            // i=2 için continue görürse işlem yapmayıp bir sonraki adıma geçer
            
            // label4.Text = "";
            //for (int i = 1; i <= 5; i++);
            //{
            //    if (i == 3) break;
            //   label4.Text += i.ToString();
            //} 
            // break olduğu için label da 1, 2 yazar.
            //for (int i = 1; i <= 5; i++) ;
            //{
            //  if (i == 3) ; continue;
            //    label4.Text += i.ToString();
            //}
            // continue olduğu için label da 1, 2, 4, 5 yazar.


            // While döngüsü
            // while(koşul)
            //  deyim 
            // while (koşul)
            // { 
            // deyim 1
            // deyim 2 
            // ...
            // }
            // koşul sağlandığı sürece deyim yapılır.Koşul sağlanmadığı zaman ise döngüden çıkılır
            // koşul sağlandığı sürece deyim 1,2 yapılır. Koşul sağlanmadığı zaman ise döngüden çıkılır.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 5)
            {
                label4.Text = i.ToString();
                i++;
            }
            label4.Text = i.ToString();
        }

        // dowhile döngüsü 
        // do
        // deyim
        // while(koşul)

        // veya

        // do
        // {
        // deyim 1 
        // deyim 2 
        // ...
        // }
        // while(koşul)
        // while den farkı önce işlem yapar sonra koşula bakar
        // dowhile döngüsünde koşullar sağlansada sağlanmasada deyimler bir kez yapılır.
        //** şifre yerlerinde dowhile kullanılır.
        // do
        // {
        // }while (label.text ==)
        private void button6_Click(object sender, EventArgs e)
        {
            int i = 1;
            do
            {
                label4.Text = i.ToString();
                i++;
            } while (i <= 5);
        }

        // foreach döngüsü(** Her dilde yoktur.)
        // Genelde koleksiyon(dizi,liste) tabanlı verilerde dolaşmak için kullanılır.
        // Örneğin; Dizilerde foreach döngüsünü kullanabiliriz
        // foreach döngüsü 
        // foreach (var item in collection)
        // foreach (tür değişken in collection)
        // {
        // deyim veya deyimler
        // }
        int a = 1;
        private void button7_Click(object sender, EventArgs e)
        {
            
            string[] x = new string[5];
            foreach (string a in x);
            {
                listBox1.Items.Add(a);  
            }
            
        }
        // sınav ilgili; if döngüler diziler
        // Diziler
        // Ardarda gelen aynı türdeki nesneler kümesine dizi denir.
        // Bir dizinin tüm elemanlarına aynı isim ile erişilir. Yani dizinin elemanöarının isimleri ortaktır
        // Dizi elemanlarını birbirinden ayıran ise bellekteki yerleridir.Dizilerde indisler 0 dan başlar.****
        // Örneğin a[5] gibi bir dizimiz varsa bu dizinin eelemanları a0, a1, a2, a3, a4.
        // Dizinin elemanlarına [] ile ulaşılır.Bir diziyi şu şekilde tanımlayabiliriz.
        // tür [] değişken= new tür[boyut];

        int k = 0; 
        private void button8_Click(object sender, EventArgs e)
        {
            int[] b = new int[4];
            foreach (int x in b)
            {
                listBox1.Items.Add(x);
            }
            for (int k = 0; k < 4; k++) ;
            {
                listBox1.Items.Add(b[k]);
            }
        }
        // Burada elemanları int türde olan bir b dizisi tanımladık bu b dizisinin 4 elemanı vardır bu elemanlar b0, b1, b2, b3 tür.
        // Burada b dizisi 4 elemanlı olduğundan b4 ü kullanamayız eğer b4 kullanmış olsaydık dizinin 5 elemanlı olması gerekirdi. 
        // Sayısal dizilerde başlangıç değeri olarak 0 ataması yapar 
        // String dizilerde başlangıç değeri null olur.
        // mantıksal dizilerde ise başlangıç değeri false.
        // Bir diziyi şu şekildede tanımlayabiliriz.
        // Bir dizinin başlangıçta elemanlarını biliyorsak diziyi şu şekildede tanımlayabiliriz.
        // double[] y = {2.1,3.67,7.8};
        // float[] z = {3.1f,4.5f,5.78f};
        // string[] t = {"Görsel Programlama","Analiz","Analitik"}
        // soru; 1 den n ye kadar olan sayıları bir diziye atayıp bu dizinin elemanlarının küpleri toplamını hesaplayan
        // bir visual c# programı yazınız.
        int i = 0;
        private void button9_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            int n = Convert.ToInt32(textBox1.Text);
            int[] a = new int[n];
            for (int i = 0; i < n; i++) ;
                a[i] = i + 1;
            for (int i = 1; i < n; i++);
                sonuc += Math.Pow(a[i],3);
            label4.Text = sonuc.ToString();
        }
        






    }   
}
