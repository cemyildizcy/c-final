using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
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
            //int a, b, c;
            //double x1, x2, d;
            //if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            //{
            //    a = Convert.ToInt32(textBox1.Text);
            //    b = Convert.ToInt32(textBox2.Text);
            //    c = Convert.ToInt32(textBox3.Text);
            //    d = b * b - 4 * a * c;
            //    if (d > 0)
            //    {
            //        x1 = (-b + Math.Sqrt(d)) / (2 * a);
            //        x2 = (-b - Math.Sqrt(d)) / (2 * a);
            //        label4.Text = "Kök 1=" + x1 + ", Kök 2=" + x2;
            //    }
            //    else if (d == 0)
            //    {
            //        x1 = -b / (2 * a);
            //        label4.Text = "Kök =" + x1;
            //    }
            //    else
            //        label4.Text = "Reel kök yoktur.";
            //}           
            //else
            //    label4.Text = "a,b ve c girilmeli";

            // switch deyimi

            // switch(ifade)
            //{
            // case durum1:
            // {
            // yapılacak işlemler_1;
            // break;
            // }
            // case durum2:
            // {
            // yapılacak işlemler_2;
            // break;
            // }
            // case durum3:
            // {
            // yapılacak işlemler_3;
            // break;
            // }
            // ...
            // default:
            // {
            // durumlar sağlanmadığında yapılacak işlemler;
            // break;
            // }
            // }

            //int a = 1;
            //switch (a)
            //{
            //    case 1:
            //        goto case 3;
            //    case 2:
            //        {
            //            label4.Text = "a 1 veya 2 ye eşittir.";
            //            break;
            //        }
            //    case 3:
            //        {
            //            label4.Text = "a 3 e eşittir.";
            //            break;
            //        }
            //    default:
            //        {
            //            label4.Text = "a 1,2,3 e eşit değildir.";
            //            break;
            //        }
            //}

            // 1 for döngüsü
            // 2 while döngüsü
            // 3 do while döngüsü
            // 4 foreach döngüsü

            // for döngüsü
            // for (ifade1;ifade2;ifade3) for(ifade1;;)
            // {
            //  yapılacak işlem(ler)
            // }

            //int i;
            //for (i = 1; i <= 4; i++)
            //{
            //    label4.Text = i.ToString();
            //    label4.Text = i.ToString();
            //}


            //int i;
            //label4.Text = "";
            //for (i = 1; i <= 5; i++)
            //    label4.Text += i.ToString() + "\n";
          
            
            for (; ;  )
                label4.Text = "deneme";

        }
    }
}
