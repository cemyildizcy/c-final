using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // return
        private void button1_Click(object sender, EventArgs e)
        {
            // Metotlar
            // [erişim belirteçleri] <geri dönüş değeri> metot ismi (parametre listesi)
            // {
            // metot gövdesi
            // }

            // public ve private
            if (textBox1.Text == "" || textBox2.Text == "")
                label3.Text = "Sayı Giriniz";
            else
            {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
                if (radioButton1.Checked)
                    label3.Text = topla(a, b).ToString();
                else if (radioButton2.Checked)
                    label3.Text = cikar(a, b).ToString();
                else if (radioButton3.Checked)
                    label3.Text = carp(a, b).ToString();
                else if (radioButton4.Checked)
                    if (b == 0)
                        label3.Text = "Sıfıra bölme olamaz";
                    else
                        label3.Text = bol(a, b).ToString();
                else
                    yaz();
                //  textBox1.Text = "";
                //  textBox2.Text = "";
            }
        }

       public double topla(double a, double b)
        {
            return a + b;
        }
        public double cikar(double a, double b)
        {
            return a - b;
        }
        public double carp(double a, double b)
        {
            return a * b;
        }
        public double bol(double a, double b)
        {
            return a / b;
        }

        void yaz()//private
        {
            MessageBox.Show("Seçim yapınız.");
        }
        private void button2_Click(object sender, EventArgs e)
        {
             Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s1, s2, s3;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            s3 = Convert.ToInt32(textBox3.Text);
            int enbuyuk = enb3(s1,s2,s3);
            label3.Text = enbuyuk.ToString();
        }
         int enb2(int a,int b)
        {
            if (a > b)
                return a;
            return b;
        }
        int enb3(int a,int b, int c)
        {
            return enb2(a,enb2(b,c));
        }

        // metot parametresi olarak diziler

        private void button4_Click(object sender, EventArgs e)
        {
            int[] d = { 23, 56, 8, 78, 5 };
            diziyaz(d);
        }

        void diziyaz(int[] x)
        {
            foreach (int i in x)
                listBox1.Items.Add(i);
        }


        // metotların aşırı yüklenmesi

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = bul(1.123f).ToString();
        }

        double bul(double a)
        {
            return a*a;
        }

        double bul(float a)
        {
            return a * a;
        }

        int bul(int a,int b)
        {
            return a * b;
        }
        int bul(int a,int b,int c)
        {
            return a * b * c;
        }
        int bul(int a, int b, int c, int d)
        {
            return a + b + c + d;//12
        }

        //double bul(int a, int b, int c, double d)
        //{
        //    return a * b * c * d;//40
        //}




        // değişken sayıda parametre alan metotlar
        // params

        private void button6_Click(object sender, EventArgs e)
        {
           // label3.Text=toplam().ToString();
           // label3.Text = toplam(5).ToString();
           // label3.Text = toplam(4,5).ToString();
           // label3.Text = toplam(4,6,7,8).ToString();
            label3.Text = toplam(6,7,8,9,5,4,3).ToString();
        }
        int toplam(params int[] sayilar)
        {
            if (sayilar.Length == 0)
                return 0;
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }

        //özyineli (recursive) metotlar

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = faktoriyel(0).ToString();
            label2.Text = faktoriyel(3).ToString();
            label3.Text = faktoriyel(20).ToString();
        }


        long faktoriyel(int n)
        {
            if (n == 0)
                return 1;
            return n * faktoriyel(n - 1);//3*faktoriyel(2) 3*2*faktoriyel(1) 3*2*1*faktoriyel(0) 3*2*1*1
        }
        // n*faktoriyel(n - 1), n*(n-1)*faktoriyel(n - 2),...n*(n-1)*...*faktoriyel(0)



        private void button8_Click(object sender, EventArgs e)
        {
            //  label2.Text = Math.Ceiling(2.1).ToString();
            //  label3.Text = Math.Floor(2.1).ToString();
            label3.Text = Math.Exp(1).ToString();
        }
    }
    
    // yeni sınıf

    // math sınıfının bazı metotları
    // abs(x)
    // cos(x)
    // sin(x)
    // tan(x)
    // ceiling(x) 
    // floor(x) 
    // max(x,y)
    // min(x,y)
    // pow(x,y)
    // sqrt(x)
    // log(x) e tabanına göre logaritma
    // exp(x)
    // log10(x)
    
}
