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

            //  Örn 6: NxN ve MxR lik bir matrisin çarpımını bulan bir VC# programı yazınız.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int[,] mat = new int[n + 1, n + 1];
            int i, j, toplam = 0;
            string satir = "";
            for (i = 1; i < n + 1; i++)
            {
                satir = "";
                for (j = 1; j < n + 1; j++)
                {
                    mat[i, j] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("A["+i+","+j+"] i giriniz", "Matrisi Girdisi", "5"));
                    // InpuxBox metodu
                    
                    satir += mat[i, j] + " ";
                    if (i+j == n+1)
                        toplam += mat[i, j];
                }
                listBox1.Items.Add(satir);
            }
            label2.Text = "Sonuç = " + toplam.ToString();
        }
    }
}
