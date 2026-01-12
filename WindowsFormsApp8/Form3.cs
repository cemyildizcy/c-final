using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked)
                label3.Text = topla(s1, s2).ToString();
            else if (radioButton2.Checked)
                label3.Text = cikar(s1, s2).ToString();
            else if (radioButton3.Checked)
                label3.Text = carp(s1, s2).ToString();
            else if (radioButton4.Checked)
                if (s2 == 0)
                    label3.Text = "Sıfıra Bölme olamaz";
                else
                    label3.Text = bol(s1, s2).ToString();
            else
                label3.Text = "Seçim Yapınız";

        }
        double topla(double a, double b)
        {
            return a + b;
        }
        double cikar(double a, double b)
        {
            return a - b;
        }
        double carp(double a, double b)
        {
            return a * b;
        }
        double bol(double a, double b)
        {
            return a / b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBox3.Text);
            int i,sonuc;
            for (i = 1; i <= n; i++)
            {
                sonuc = faktoriyel(i);
                listBox1.Items.Add(i+"!="+sonuc);
            }
        }
        int faktoriyel(int n)
        {
            int carp = 1;
            for (int i = 1; i <= n; i++)
                carp *= i;
            return carp;//f(x)=x**2+x+1 fonksiyonu ve girilen bir n için fo(fo(fo()...)) (n tane bileşke) ifadesini hesaplayan bir vc# programı yazınız
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n, m;
            double sonuc;
            n = Convert.ToInt32(textBox3.Text);
            m = Convert.ToInt32(textBox4.Text);
            if (m <= n)
            {
                sonuc = faktoriyel(n) / (faktoriyel(m) * faktoriyel(n - m));
                label3.Text = n+" nin " +m+" li kombinasyonu="+sonuc+" dir.";
            }
            else
                label3.Text = "m, n den küçük veya eşit olmalı";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // int n = Convert.ToInt32(textBox5.Text);
            //  double x = Convert.ToDouble(textBox6.Text);
            // for(int i=1;i<=n;i++)
            //  {
            //      x= f(x);
            //  }
            // label3.Text = x.ToString();
            label7.Text = faktoriye(5).ToString();

        }

        // değişken sayıda parametre alan metotlar
        // params
        int faktoriye(int k)
        {
            if (k == 0)
                return 1;
            return k * faktoriye(k-1);
            // 5*faktoriye(4)
            // 5*4*faktoriye(3)
            // 5*4*3*faktoriye(2)
            // 5*4*3*2*faktoriye(1)
            // 5*4*3*2*1*faktoriye(0)
            // 5*4*3*2*1*1
        }
    }
}
