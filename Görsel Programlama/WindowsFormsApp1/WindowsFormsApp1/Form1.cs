using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Değişkenler 
            // Değer Tipleri : Değişkenin değeri doğrudan bellekte saklanır.(stack-yığın)
            // Referans Tipleri : Değişkenin adresi bellekte saklanır,değeri heap-öbek bölgesinde tutulur.
            //Değer tipleri;
            //byte veri türü: 8 bitlik tam sayıyı saklamak için kullanılır.
            //Dolayısıyla byte türden bir değişkene atayabileceğiimiz tam sayılar şunlardır; 0..255
            ///byte a = 2;
            ///byte b = 45;
            ///byte c = 34, d = 228;
            //sbyte veri türü: 8 bitlik işaretli tamsayı veri türüdür.
            //sbyte türünde bir değişkene atayabileceğimiz değer aralığı şöyledir; -128 ile 127
            ///sbyte aa = 34;
            /// sbyte bb = -125;
            ///sbyte sayi_topla = 100;
            ///sbyte cc = -128, dd = 127;
            //short veri türü: 2 byte lık işaretli tamsayı veri türüdür.
            //ushort veri türü: 2 byte lık işaretsiz tamsayı veri türüdür.
            //Bu değişkenlerin alabileceği tamsayı sınırları şöyledir; short -32768...32767 ushort 0...65535
            //int veri türü: 4 byte lık işaretli tam sayı veri türüdür.
            //uint veri türü: 4 byte lık işaretli tamsayı veri türüdür.
            //Bu türden değişkenlere aktarabileceğimiz verilerin sınırları şöyledir; int 2^31...2^31-1 uint 0...2^32-1
            //long veri türü: 8 byte lık işaretli tamsayı veri türüdür.
            //ulong veri türü: 8 byte lık işaretli tamsayı veri türüdür.
            //Bu türden değişkenlere aktarabileceğimiz verilerin sınırları şöyledir; long 2^63...2^63-1 ulong 0...2^64-1
            ///long x = 34; // 80b daha fazla yer kaplar. 
            ///byte y = 3; //  10b daha az yer kaplar.
            /// byte a = 34, b = 45, c;
            // c = a + b; byte türünde değişkenlerle matematiksel işlem yapılırsa değişken byte türünde olamaz hata verir

            // float veri türü : 4 byte lık ondalıklı veri türüdür.
            // float türden bir değişkene değer ataması yağılırken sayının sonuna f veya F getirilir.
            float z = 5.1f;
            float s = 4.5F;
            // double veri türü : 8 byte lık ondalıklı veri türüdür.
            // ddouble türde bir değişkene veri aktarırken sayının sonuna d,D veya herhangi bir şey getirilmez.
            double q = 5.5d;
            double o = 55.67D;
            double u = 567.345;
            ///double t = a + b;
            ///label1.Text = x.ToString();
            // float yy = 2.3;f koymadığımız için 2.3 double oluyor.
            // decimal veri türü: 16 byte lık ondalıklı veri türüdür.
            // decimal türde bir değişkene değer ataması yapılırken sayının sonuna m veya M getirilir.
            decimal a1 = 3.12m;

            // bool veri türü: true veya false değerlerini saklamak için kullanılır.
            // bool türden bir değişkene bu değerler dışında karşılaştırma operatörlerinin sonuçlarıda aktarılabilir.
            bool b1 = false;
            bool b2 = true;
            int i = 45;
            bool b3 = i < 65;
            label1.Text = b3.ToString();

            // char veri türü:16 bit uzunluğunda evrensel bir kod olan unicode standartlarındaki karakterleri temsil etmek için kullanılır.
            // ascii 256 tane standart karakter barındırıyor.ilk 32 nin görsel bir karşılığı yok.
            // charset
            // unicode:120000 küsür karakter barındırıyor.
            char c1 = 'A';
            char C2 = (char)78;


            // Referans türler
            // string veri türü: string veri türünü unicode karakterlerden oluşan bir dizi gibi düşünebiliriz.
            // string türden bir değişkene veri aktarırken; " " kullanılır.
            ///string s3 = "Görsel";
            ///string s1 = "Programlama II";
            ///string s2 = s3 + s1;
            ///label1.Text = s2;
            //string dosya = "c:\\okul\\deneme.txt";
            //string dosya = @"c:\okul\deneme.txt";
            //string a = "deneme";
            int b = 61;
            label1.Text = a + b;
            b = 102;
            // Object veri türü:c# bütün veri türleri gizli olarak object veri türünden türer.
            // Nesneler birer obje olduğundan bütün değerler ve nesneler obje türünden bir değişkene atanabilir.
            object aa;
            aa = 5;
            label3.Text = aa.GetType().ToString();
            aa = 'A';
            //label4.Text = aa.GetType().ToString();
            //aa = 15.2;
            //label5.Text = aa.GetType().ToString();
            //aa = 45.7m;
            //label6.Text = aa.GetType().ToString();
            //aa = true;
            //label7.Text = aa.GetType().ToString();
            // var

            // TÜR DÖNÜŞÜMÜ 
            // Büyük çaplı projelerde çok fazla değişken vardır. Bazen bu değişkenler ile işlemler yapmak isteyebiliriz. 
            // Örneğin int türden bir sayı ile double türden bir sayıyı toplamak isteyebiliriz.
            // Bu gibi durumlarda tiplerin uyumlu olabilimesi için tür dönüşümü yapmış oluruz.
            // Örnek; string bir veri türünü int türden bir veri ile birleştirmek istersek int veri türünü stringe geçici olarak
            // dönüştürmemiz gerekir.C# tür dönüşümlerini genel olarak iki alt başlıkta inceleriz bunlar;
            // Bilinçsiz tür dönüşümü,
            // Bilinçli tür dönüşümüdür.
            // Bilinçsiz Tür Dönüşümü
            // devleyici tarafından bir değişkeni tanımladığımız tür dışında geçici olarak başka bir türe dönüştürülmesine denir.
            //int a9 = 5;
            //float b9 = a9;
            // Örneğin; int türde olan a değişkeni float türden olan b değişkenine atanmıştır bu atama işleminden önce
            // a değişkeni geçici olarak float türe dönüştürülüp float türdeki b değişkenine atanmıştır.
            // bu dönüşümden sonra a değişkeni yine int olarak işleme devam edecektir burada a değişkeninini devleyici 
            // dolayısıyla burada bilinçsiz tür dönüşümü yapılmıştır bilinçsiz olarak küçüktür büyüktüre dönüştürülebilir
            // fakat büyüktür küçüktüre dönüsütürülemez büyüktürün küçüktüre dönüştülümemesinin sebebi veri kaybını önlemektir.
            // çünkü büyüktür küçüktüre dönüştürüldüğünde çoğu zaman veri kaybı olur.
            // byte a = 12;
            // int b;
            // b = a;
            // label9.Text = b.ToString();

            //int c = 23;
            // byte d;
            // d = c;

            //float f = 3.4f;
            //double g = 3.5f;

            // Bilinçli Tür Dönüşümü
            // Bilinçli tür dönüşümü genellikle devleyicinin izin vermediği durumlarda kullanılır.
            // Fakat programın anlaşılabilirliğini artırmak için her durumda bilinçli tür dönüşümünü kullanmamız tavsiye edilir.
            // Bilinçli tür dönüşümde hem küçüktürü büyüktüre hem de büyüktürü küçüktüre dönüştürebiliriz.
            // Tür dönüştürme operatörü olarak () kullanılır.
            // Örnek;
            //byte b8 = 34;
            //int a8 = (int)b8;
            //int c8 = 256;
            //byte d8 = (byte)c8;
            //label7.Text = d8.ToString();

            // xxxxxxxx xxxxxxxx xxxxxxxx xxxxxxxx 4byte
            // xxxxxxxx 1byte

            //  00000000 00000000 00000000 00000000 int olarak 256 nın bellekteki görünümü

            // burada bilinçli olarak hem küçüktürü büyüktüre hemde büyüktürü küçüktüre dönüştürmüş olduk bu dönüşüm sonucunda
            // veri kaybı olsada olmasada devleyici bizi uyarmaz. çünkü bu işlemi bilinçli yaptığımız için veri kaybını umursamayacak.
            // checked - unchecked 
            // büyüktür küçüktüre bilinçli olarak dönüştürüldüğünde veri kayıpları olabilmektedir bunun önüne geçmek için
            // c# checked ve unchecked getirilmiştir.Bilinçli tür dönüşümünü checked bloğu içinde yaparsak veri kaybı olduğunda bizi uyaracaktır
            // checked 
            //{
            //    byte d8 = (byte)c8;
            //}
            //




        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
