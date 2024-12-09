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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // İKİ BOYUTLU DİZİLER
            // tür [,] değişken = new tür[boyut1, boyut2];
            //int[,] a = new int[4, 4]; // 4x4 = 16 elemanı vardır;
            //  a[0, 0], aa[0, 1], aa[0, 2], aa[0, 3]
            //  a[1, 0], aa[1, 1], aa[1, 2], aa[1, 3]
            //  a[2, 0], aa[2, 1], aa[2, 2], aa[2, 3]
            //  a[3, 0], aa[3, 1], aa[3, 2], aa[3, 3]
            //double[,] aa = new double[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } }; //2x3
            //int[,,] aaa = new int[4, 4, 4]; // 3 boyutlu dizi
            //  a[0, 0, 0], aa[0, 0, 1], aa[0, 0, 2]
            //  a[0, 1, 0], aa[0, 1, 1], aa[0, 1, 2]
            //  a[0, 2, 0], aa[0, 2, 1], aa[0, 2, 2]
            //  a[0, 3, 0], aa[0, 3, 1], aa[0, 3, 2]
            //  
            //  a[1, 0, 0], aa[1, 0, 1], aa[1, 0, 2]
            //  a[1, 1, 0], aa[1, 1, 1], aa[1, 1, 2]
            //  a[1, 2, 0], aa[1, 2, 1], aa[1, 2, 2]
            //  a[1, 3, 0], aa[1, 3, 1], aa[1, 3, 2]
            //  
            //  a[2, 0, 0], aa[2, 0, 1], aa[2, 0, 2]
            //  a[2, 1, 0], aa[2, 1, 1], aa[2, 1, 2]
            //  a[2, 2, 0], aa[2, 2, 1], aa[2, 2, 2]
            //  a[2, 3, 0], aa[2, 3, 1], aa[2, 3, 2]
            //  
            //  a[3, 0, 0], aa[3, 0, 1], aa[3, 0, 2]
            //  a[3, 1, 0], aa[3, 1, 1], aa[3, 1, 2]
            //  a[3, 2, 0], aa[3, 2, 1], aa[3, 2, 2]
            //  a[3, 3, 0], aa[3, 3, 1], aa[3, 3, 2]


            //  Örn 1: NxN lik bir matrisin köşegen üzerindeki elemanların
            //  toplamını bulan bir VC# programı yazınız

            //  Örn 2: NxN lik bir matrisin 2. satırı ile 3. sütunun toplamını bulan
            //  bir VC# programı yazınız

            //  Örn 3: NxN lik bir matrisin elemları tek olanların toplamı bulan
            //  bir VC# programı yazınız

            //  Örn 4: NxN lik 2 matrisin toplamını bulan bir VC# programı yazınız.

            //  Örn 5: NxN lik bir matrisin transpozunu bulan bir VC# programı yazınız.

            //  Örn 6: NxM ve MxR lik bir matrisin çarpımını bulan bir VC# programı yazınız.


            // METHODLAR

            // Bütün kodların tek bir method içinde olması kötü bir tekniktir hem de
            // geliştirme aşaması zordur. Bu yüzden program geliştirirken kodları
            // parçalamalıyız. Her parça kendisine atanan görevden sorumlu olmalıdır.
            // Bir parçanın görevini yapamaması diğer parçaları etkilememelidir.
            // Bur parçalar methodlar ile yazılır.

            // Programların iş yapan en temel parçaları methodlardır. İş yapan bu methodlar,
            // çeşitli şekillerde paketlenerek başka kullanıcılar tarafından da tercih edilebilir.
            // Methodların belirli bir şekilde paketlenmesi sınıf dediğimiz yapıları oluşturur.

            // Methodlar tek başına çalıştırılabilen yapılar değildir.

            // Methodlar, değerler döndürebilir. Bir method tekrar çağırılana kadar iş yapmadan bekler.
            // Bir methodun iş yapması için, kendisini çağıran methoddan aldığı bilgilere parametre veya
            // method argümanları denir. Kendisini çağıran fonksiyona döndürdüğü bilgiye ise methodun
            // geri dönüş değeri denir.

            // Methodlar kaynak kodlarımızın tekrar kullanılabilmesi için oluşturulan yapılardır.
            // Örneğin; girilen n tane sayının faktoriyelini hesaplamak istersek faktoriyel methodunu
            // n kez çağırmamız gerekir

            // C#'ta bir methodu şu şekilde tanımlarız;
            // [erişim belirteçleri] <geri dönüş değeri> method ismi(parametre listesi)
            // {
            //     method gövdesi
            // }

            // Erişim belirteçleri ile bu methoda nerden erişilebileceğini belirtebiliriz.
            // public, private, ...
            // Eğer, herhangi bir erişim belirteçi kullanılmazsa private olur.

            // Bir fonksiyon geriye ne tür bir veri döndürecekse türünü yazarız.
            // Ardından methoda uygun bir isim verip parametrelerini ona göre tanımlarız.

            //int topla(int a, int b)
            //{
            //    return a + b;
            //}

            // Topla methodu, işlem yaptıktan sonra kendisini çağıran methoda int
            // türde veri döndürecek.

            // return ile veri geri döndürülür.
            // Geri dönüş tipi void olursa, bu method geri veri döndürmeyecektir demektir.
            // Dolayısıyla bir fonksiyonda ya return olur ya da void olur. İkisi aynı anda olmaz.

            // Bir method içinde başka bir method olamaz ama bir method içinde başka bir method
            // çağırılabilir.
            topla(2, 3);
        }

        private int topla(int a, int b)
        {
            return a + b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            int r = Convert.ToInt32(textBox3.Text);

            int[,] A = new int[n + 1, m + 1];
            int[,] B = new int[m + 1, r + 1];
            int[,] C = new int[n + 1, r + 1];

            int i, j, k, t;

            string satir1 = "", satir2 = "", satir3 = "";

            for (i = 1; i < n + 1; i++)
            {
                for (j = 1; j < m + 1; j++)
                {
                    A[i, j] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("A["+i+","+j+"] i giriniz", "Matrisi Girdisi", "5", 400, 400));
                    // InpuxBox metodu
                    satir1 += A[i, j] + " ";
                }
                listBox1.Items.Add(satir1);
                satir1 = "";
            }

            for (i = 1; i < m + 1; i++)
            {
                for (j = 1; j < r + 1; j++)
                {
                    B[i, j] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("B[" + i + "," + j + "] i giriniz", "Matrisi Girdisi", "5", 400, 400));
                    // InputBox metodu
                    satir2 += B[i, j] + " ";
                }
                listBox2.Items.Add(satir2);
                satir2 = "";
            }

            for (i = 1; i < n + 1; i++)
            {
                for (j = 1; j < r + 1; j++)
                {
                    t = 0;
                    for (k = 1; k < m + 1; k++)
                        t += A[i, k] * B[k, j];

                    C[i, j] = t;
                    satir3 += C[i, j] + " ";
                }
                listBox3.Items.Add(satir3);
                satir3 = "";
            }
        }
    }
}
