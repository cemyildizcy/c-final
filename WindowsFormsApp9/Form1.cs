using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using matbil;
using A;
using A.B;
using A.B.C;
using A.B.C.D;
using A.B.C.D.E;
using ma1 = matematik.mat; // takma isim kullandık
using ma2 = bilgisayar.mat;  // takma isim kullandık

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // label1.Text = "";
            // Math sınıfı ve metotları
            // Abs(x), Cos(x), Sin(x), Tan(x), Ceiling(x), Floor(x), Max(x,y), Min(x,y), Pow(x,y), Sqrt(x), Log(x), Exp(x), Log10(x)
            //label1.Text += Math.Abs(-20)+"\n";
            //label1.Text += Math.Cos(Math.PI/3) + "\n";//derece radyana dönüştürülmeli
            //label1.Text += Math.Sin(30) + "\n";
            //label1.Text += Math.Tan(45) + "\n";
            //label1.Text += Math.Ceiling(3.51) + "\n";
            //label1.Text += Math.Floor(3.1) + "\n";
            //label1.Text += Math.Max(3,7) + "\n";
            //label1.Text += Math.Min(3,8) + "\n";
            //label1.Text += Math.Pow(2,3) + "\n";
            //label1.Text += Math.Sqrt(25) + "\n";
            //label1.Text += Math.Log(1) + "\n";
            //label1.Text += Math.Exp(1) + "\n";
            //label1.Text += Math.Log10(10) + "\n";

            // Classlar (sınıflar)
            // değişkenler(özellikler) ve metotlardır
            // yapıcı metot ve yıkıcı metot olarak isimlendirilir

            // class sınıf_adı
            // {
            // değişken 1;
            // değişken 2;
            // ...
            // metot1;
            // metot2;
            // ...
            // }
            // sınıf_adı nesne_adı=new sınıf_adı()
            //ornek orn = new ornek(4,7);

            // nesne_adı.sınıfın_üye_elemanı
            //o.b = 23;
            // private, public, protected, internal, internal protected

            // set ve get anahtar sözcükleri

            // yapıcı ve yıkıcı metotlar
            // Yapıcı metotlar - Varsayılan yapıcı metotlar
            // Yıkıcı metotlar / dispose()
            // ~ 
            // statik üye elemanlar
            // static
          //  matematik m = new matematik();
          //  matematik.topla(34,87);
         //   matematik.a = 23;
            //  m.b = 55;
            //  nesne_adı.üye_eleman_adı - üye eleman statik değil ise
            //  sınıf_adı.üye_eleman_adı - üye eleman statik ise
            // Math.Pow();
            // matbil.mat m = new matbil.mat(); // birinci yol - tam isim kullandık
            // m.yaz();
            // mat m1 = new mat(); // ikinci yol
            //  A.B.C.D.E.mat m2 = new A.B.C.D.E.mat(); // tam isim kullandık
            // mat m3 = new mat(); // ikinci yol
           // ma1 m5 = new ma1();
           // ma2 m6 = new ma2();
           

            // C# ta tarih ve zaman işlemleri
            // system 
            // DateTime ve TimeSpan

            // Date
            // Month
            // Day
            // Year
            // DayOfWeek
            // DayOfYear
            // TimeOfDay
            // Hour
            // Minute
            // Second
            // Millisecond
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int y, a, g;
            y = Convert.ToInt32(textBox1.Text);
            a = Convert.ToInt32(textBox2.Text);
            g = Convert.ToInt32(textBox3.Text);
            DateTime bugun = DateTime.Today;
            DateTime dt = new DateTime(y,a,g);
            TimeSpan fark = bugun - dt;
            label4.Text = "Doğduğunuz Gün:" + dt.DayOfWeek;
            label5.Text = "Geçen gün sayısı:"+fark.Days;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int gs;
            gs = Convert.ToInt32(textBox3.Text);
            TimeSpan fark = new TimeSpan(gs,0,0,0);
            DateTime dt = DateTime.Today + fark;
            label5.Text = dt.DayOfWeek.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int y1, a1, g1, y2, a2, g2;
            y1 = Convert.ToInt32(textBox1.Text);
            a1 = Convert.ToInt32(textBox2.Text);
            g1 = Convert.ToInt32(textBox3.Text);
            y2 = Convert.ToInt32(textBox4.Text);
            a2 = Convert.ToInt32(textBox5.Text);
            g2 = Convert.ToInt32(textBox6.Text);
            DateTime t1 = new DateTime(y1,a1,g1);
            DateTime t2 = new DateTime(y2, a2, g2);
            TimeSpan fark = t2 - t1;
            int hss = 0;
            DateTime gecici;
            for (int i=0;i<=fark.Days;i++)
            {
                gecici = t1.AddDays(i);
                if (gecici.DayOfWeek == DayOfWeek.Sunday || gecici.DayOfWeek == DayOfWeek.Saturday)
                    hss++;
            }
            label5.Text = "Haftasonu sayısı:" + hss;
        }
    }
    static class matematik
    {
        public static int a;
        public static int b;
        public static int topla(int x,int y)
        {
            return x + y;
        }
    }
}
// namespace - isim uzayı - isim alanı
namespace matbil
{
    class mat
    {
        public void yaz()
        {
            MessageBox.Show("Matematik alanını seçen öğrenciler");
        }
    }
}

namespace A
{
    namespace B
    {
        namespace C
        {
            namespace D
            {
                namespace E
                {
                    class mat
                    {
                        public void yaz()
                        {
                            MessageBox.Show("Matematik alanını seçen öğrenciler");
                        }
                    }
                }
            }
        }
    }
}
namespace matematik
{
    class mat
    {
        public void yaz()
        {
            MessageBox.Show("Matematik alanını seçen öğrenciler");
        }
    }
}
namespace bilgisayar
{
    class mat
    {
        public void yaz()
        {
            MessageBox.Show("Matematik alanını seçen öğrenciler");
        }
    }
}