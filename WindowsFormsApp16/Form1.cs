using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Döngüler

            // for döngüsü
            // while dö
            // do while dö.
            // foreach döngüsü

            //for (int i = 0; i < 20; i++)
            //{
            //    label1.Text = i.ToString();
            //}


            //int i=1;
            //for (; ;)
            //{
            //  //  i++;
            //    label1.Text = i.ToString();
            //    i++;
            //    if (i == 61) break;
            //    //i++;
            //}

            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        label1.Text = i + ",  " + j;
            //    }
            //    //i=1, j=1,2,3,4,5
            //    //i=2, j=1,2,3,4,5
            //    //i=3, j=1,2,3,4,5
            //    //i=4, j=1,2,3,4,5
            //}

            // while döngüsü
            // while (koşul)
            // {
            // işlem(ler)
            // }

            //int k = 1;
            //while (k <= 11)
            //{
            //  //    k++;
            //    label1.Text = k.ToString();
            //  //  k += 3;
            //}

            // do while döngüsü
            // do
            //  {
            //   işlem(ler)
            //  }
            //  while (koşul)
            //  

            //int i = 1;
            //do
            //{
            //    label1.Text = i.ToString();
            //    ++i;
            //} while (i <= 10);

            // foreach döngüsü
            // koleksiyon 

            // foreach(tip ifade in koleksiyon)
            // {
            // işlem(ler)
            // }

            //int[] dizi = new int[10];
            //foreach (int i in dizi)
            //{
            //    listBox1.Items.Add(i);//null
            //}

            // continue, break

            //for (int i = 1; i <= 22; i++)
            //{
            //    if (i == 5) continue;
            //    label1.Text = i.ToString();
            //    if (i == 6) break;
            //}

            // diziler

            // tür [] değişken;
            // değişken=new tür[boyut];

            // veya

            //  tür[] değişken=new tür[boyut];

            //int[] a = new int[5];
            //  a[0], a[1], a[2], a[3], a[4]
            //veya
            //int[] aa;
            //aa = new int[5];
            //a[0] = 23;
            //listBox1.Items.Add(a[1]);//null

            //string[] ab = { "Analiz I", "Görsel Prg. I", "Lineer Cebir", "Web Tabanlı Uyg" };
            //double[] ab1 = { 1.3, 3.6, 8.6 };
            //short[] ab2 = { 3,56,78,32,1 };


            //foreach (string x in ab)
            //{
            //    listBox1.Items.Add(x);
            //}

            //for (int i = 0; i <= 3; i++)
            //{
            //    listBox1.Items.Add(ab[i]);
            //}

            // iki boyutlu diziler

            //  tür[,] değişken = new tür[boyut1, boyut2];
            //int[,] a1 = new int[5, 5];


            //   a1[0,0], a1[0,1], a1[0,2], a1[0,3], a1[0,4]
            //   a1[1,0], a1[1,1], a1[1,2], a1[1,3], a1[1,4]
            // ...
            // ...
            //   a1[4,0], a1[4,1], a1[4,2], a1[4,3], a1[4,4]

            //int[,] a2 = { { 1,5 },{ 7,8 }, { 6,9 } };      
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)    
            //    {
            //        listBox1.Items.Add(a2[i,j]);
            //    }               
            //}


            //int n, toplam = 0;
            //n = Convert.ToInt32(textBox1.Text);
            //int[] x = new int[n];
            //for (int i = 0; i <= n - 1; i++)
            //{
            //    //  x[i] = Convert.ToInt32(textBox2.Text);
            //    x[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(i + 1 + ". elemanı giriniz", "Diziler", "", 1, 100));
            //    toplam += x[i];
            //}
            //listBox1.Items.Add(toplam);

            //int n, t1 = 0, t2 = 0;
            //string satir = "";
            //n = Convert.ToInt32(textBox1.Text);
            //int[] x = new int[n];
            //for (int i = 0; i <= n - 1; i++)
            //{
            //    x[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(i + 1 + ". elemanı giriniz", "Diziler", "", 100, 100));
            //    satir = "x[" + i + "]=";
            //    listBox1.Items.Add(satir + x[i]);
            //    if (i % 2 == 0)
            //        t2 += x[i] * x[i]; //math.pow(x[i],2)
            //    else
            //        t1 += x[i];
            //}
            //label2.Text = "Tek İn Top=" + t1 + ", Çift İn Kare Top=" + t2;

            //int n, t1 = 0, t2 = 0;
            //string satir = "";
            //n = Convert.ToInt32(textBox1.Text);
            //int[] x = new int[n];
            //for (int i = 0; i <= n - 1; i++)
            //{
            //    x[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(i + 1 + ". elemanı giriniz", "Diziler", "", 100, 100));
            //    satir = "x[" + i + "]=";
            //    listBox1.Items.Add(satir + x[i]);
            //    if (x[i] % 2 == 0)
            //        t2 += x[i] * x[i];
            //    else
            //        t1 += x[i];
            //}
            //label2.Text = "Tek Ol Top=" + t1 + ", Çift Ol Kare Top=" + t2;

            int n, t = 0;
            string satir = "";
            n = Convert.ToInt32(textBox1.Text);
            int[] x = new int[n];
            for (int i = 0; i <= n - 1; i++)
            {
                x[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(i + 1 + ". elemanı giriniz", "Diziler", "", 100, 100));
                satir = "x[" + i + "]=";
                listBox1.Items.Add(satir + x[i]);
            }
            for (int i = 0; i <= n - 2; i++)
            {
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (x[i] < x[j])//(x0=1)<(x1=3) , (x0=3)<(x2=2) mi? (x0=3)<(x3=6)
                    {
                        t = x[i];// t=1, t=3
                        x[i] = x[j]; //x0=3 , x0=6
                        x[j] = t; // x1=1, x3=3
                    }
                }
            }
            for (int i = 0; i <= n - 1; i++)
            {
                satir = "x[" + i + "]=";
                listBox2.Items.Add(satir + x[i]);
            }
            label2.Text = (x[0] + x[n - 1]).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
