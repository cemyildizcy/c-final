using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // döngü yapıları

            // for döngüsü
            // while döngüsü
            // do while döngüsü
            // foreach döngüsü

            // for döngüsü
            // for (ifade1;ifade2;ifade3)
            // işlem1
            // veya
            // for (ifade1;ifade2;ifade3)
            // {
            // işlem1
            // işlem2
            // ...
            // }

            //int i=2;
            //for (; ; )
            //{
            //    label1.Text = i.ToString();

            //    if (i == 35) break;
            //    i++;
            //}

            //int i=0, j=0;
            //for (i = 0; i <=5; i++)
            //{
            //    for (j = 0; j <=6; j+=2)
            //    {
            //        label1.Text = (i + j).ToString();
            //    }
            //}
            //label1.Text = (i + j).ToString();//6+8

            // i=0 için j=0 2 4 6
            // i=1 için j=0 2 4 6
            // i=2 için j=0 2 4 6
            // i=3 için j=0 2 4 6
            // i=4 için j=0 2 4 6
            // i=5 için j=0 2 4 6

            // while döngüsü

            // while (koşul)
            //  {
            // yapılacak işlemler
            //  }

            //int i = 1,top=0;
            //while (i<=1000)
            //{
            //    top += i;// top=top+i;
            //    label2.Text = i.ToString();
            //    i++;
            //    if (top >= 100) break;
            //}
            //label1.Text = top.ToString();

            // do while döngüsü

            //  do
            //  {
            //      yapılacak işlemler
            //  } while (koşul);

            //int i = 1;
            //do
            //{
            //    label1.Text = i.ToString();
            //} while (i<1);



            //while (i < 1)
            //{
            //    label1.Text = i.ToString();
            //}

            // foreach()
            // koleksiyonlarda kullanırız (örn diziler listeler)

            //foreach (int i in dizi)
            //{
            //    işlemler;
            //}

            // continue
            // break
            // goto

            //  etiket:
            //  işlemler
            //  goto etiket;

            //    int i = 1,toplam=0;
            //a:
            //    toplam += i;
            //    i++;
            //    goto a;
            //    label1.Text = toplam.ToString();


            //label1.Text = "";
            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 3) continue;
            //    label1.Text += i+"\n";
            //}

            // Diziler

            // dizi[0]
            // dizi[1]
            // dizi[2]
            // dizi[3]
            // dizi[4]
            // dizi[5]
            // dizi[6]
            // dizi[7]
            // dizi[8]
            // dizi[9]
            // dizi[10] dizi 10 elemanlı olduğu için bu olmaz

            // veri_türü[] dizi_adı = new veri_türü[boyut];

            // int[] a = new int[10];
            //a[0]=12;
            //a[1]=21;
            //a[2];
            //a[3];
            //a[4];
            //a[5];
            //a[6];
            //a[7];
            //a[8];
            //a[9];
            // null

            //for (int i = 0; i <= 9; i++)
            //    listBox1.Items.Add(a[i]);

            // veri_türü[] dizi_adı;
            // dizi_adı = new veri_türü[boyut];

            //int[] a;
            //a = new int[10];

            //int[] a = new int[10];

            //int[] a = new int[10];

            // int[] a = {1,3,45,34,8,65};
            // float[] a = { 2.1f, 4.5f,6.7f };

            //string[] a = {"hasan","yusuf","elif","ahmet","ela"};


            // iki boyutlu diziler
            // veri_türü[,] dizi_adı = new veri_türü[boyut1,boyut2];

            // int[,] a = new int[5,4];
            // a[0,0],a[0,1],a[0,2],a[0,3]
            // a[1,0],a[1,1],a[1,2],a[1,3]
            // a[2,0],a[2,1],a[2,2],a[2,3]
            // a[3, 0],a[3, 1],a[3, 2],a[3, 3]
            // a[4, 0],a[4, 1],a[4, 2],a[4, 3]

            int[,] a = { { 1, 2, 4 },{ 5, 6, 7 },{ 6, 5, 9 } };

            //foreach (int i in a)
            //{
            //    listBox1.Items.Add(i);
            //}

            for (int i = 0; i <=2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    listBox1.Items.Add(a[i,j]);//a[0,0]a[0,1]a[0,2]a[1,0]a[1,1]a[1,2]a[2,0]a[2,1]a[2,2]
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }
