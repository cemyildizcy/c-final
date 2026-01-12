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

namespace WindowsFormsApp8
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
            d = b * b - 4 * a * c;//math.pow(b,2)-4*a*c
            if (a != 0)
            {
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    label4.Text = "Kök 1=" + x1 + ", Kök 2=" + x2;
                }
                else if (d == 0)
                {
                    x1 = -b / (2.0 * a);
                    label4.Text = "Kök=" + x1;
                }
                else
                    label4.Text = "Reel kök yoktur";
            }
            else
                label4.Text = "a sıfır olamaz";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 12;
            switch (a)
            {
                case 2:
                case 25:
                    label4.Text = "a nın değeri 2 veya 25 dir";
                    break;
                case 12:
                    goto case 25;
                default:
                    label4.Text = "a nın değeri 2, 12, 25 değildir";
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //  int i=0,j=0;
            //  double d = 34;
            //   label4.Text = "";
            //   for (i=1;i<=5;i++ )
            //  {
            //     for(j=1;j<=3;j++)
            //          label4.Text += (i + j).ToString()+"\n";
            // }
            // label4.Text = (i+j).ToString();

            // break , continue
           // label4.Text = "";
           // for (int i = 1; i <= 5; i++)
          //  {                
           //     if (i == 3) break;
           //     label4.Text += i.ToString();
           // }

          //  label4.Text = "";
          //  for (int i = 1; i <= 5; i++)
          //  {
           //     if (i == 3) continue;
           //     label4.Text += i.ToString();
           // }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //  int i = 1;
            // while (i <= 5)
            //  {
            //     label4.Text = i.ToString();
            //    i++;
            // }
            // label4.Text = i.ToString();

            // do
            // deyim
            // while (koşul)

            // veya

            // do
            // {
            // deyim 1
            // deyim 2
            // ...
            // }
            // while (koşul)

            //  do
            //  {
            //      label4.Text = i.ToString();
            //     i++;
            // } while (i <= 5);
            // foreach döngüsü
            // koleksiyon
            // foreach (tür değişken in koleksiyon)
            // {
            //     deyim veya deyimler
            //  }

            //  string[] x = new string[5];
            //  foreach (string i in x)
            //  {
            //     listBox1.Items.Add(i);
            //  }

            // diziler
            // a[5]
            // a0,a1,a2,a3 ve a4
            // []

            // tür [] değişken=new tür[boyut];

            // tür [] değişken;
            // değişken=new tür[boyut];

            double[] x;
            x = new double[10];

            double[] y = {2.1,3.67,7.8};
            float[] z = {3.1f,4.5f,5.78f};
            string[] zz = {"analiz 1","nümerik analiz 1","analitik geo. 1","teknik ing"};

            bool[] a = new bool[4];
           // foreach (int x in a)
           // {
          //      listBox1.Items.Add(x);
           // }

            for (int i = 0; i < 4; i++)
            {
                listBox1.Items.Add(zz[i]);// null 
            }
            // iki boyutlu diziler
            // tür [,] değişken=new tür[boyut1,boyut2];
           // int[,] aa = new int[4,4];
            // aa[0,0],aa[0,1],aa[0,2],aa[0,3]
            // aa[1,0],aa[1,1],aa[1,2],aa[1,3]
            // aa[2,0],aa[2,1],aa[2,2],aa[2,3]
            // aa[3,0],aa[3,1],aa[3,2],aa[3,3]

            //  double[,] y = {{2.1,3.67,7.8},{2.3,5.6,7.8}};2x3
            // int[,,] aaa = new int[4,4,3];3 boyutlu dizi
            // aaa[0, 0,0],aaa[0,0, 1],aaa[0,0, 2]
            // aaa[0, 1,0],aaa[0,1, 1],aaa[0,1, 2]
            // aaa[0, 2,0],aaa[0,2, 1],aaa[0,2, 2]
            // aaa[0, 3,0],aaa[0,3, 1],aaa[0,3, 2]
            // ...
            // Örn 1: nxm ve mxr

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sonuc=0;
            int n = Convert.ToInt32(textBox1.Text);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = i+1;
            for (int i = 0; i < n; i++)
                sonuc += Math.Pow(a[i],3);
            label4.Text = sonuc.ToString();
        }




        // switch karar yapısı
        // switch(ifade)
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
        // yapılacak diğer işlemler;
        // break;
        // }
    } // goto

    // for, while, do while, foreach

    // for döngüsü
    // for (ifade1;ifade2;ifade3)
    // işlem veya işlemler
    // while döngüsü
    // while (koşul)
    // deyim
    // veya
   // while (koşul)
   // {
   // deyim 1
   // deyim 2
   // ...
   // }
   
}
