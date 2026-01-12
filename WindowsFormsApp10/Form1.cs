using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // String işlemleri
            // string cumle = "www.bulentsaka.com";
            // ToLower() 
            // textBox1.Text = cumle.ToLower();
            // ToUpper()
            // textBox1.Text = cumle.ToUpper();
            // Replace()
            // textBox1.Text = cumle.Replace("şimdiden", "bir an önce");
            // Trim()
            //  textBox1.Text = cumle.Trim();
            // TrimStart() TrimEnd()
            //textBox1.Text = cumle.TrimStart();
            // textBox1.Text = cumle.TrimEnd();
            // StartsWith()
            // textBox1.Text =Convert.ToString(cumle.Trim().StartsWith("PROJE"));
            // EndsWith()
            //  textBox1.Text = Convert.ToString(cumle.Trim().EndsWith("belirleyin"));
            // Contains()
            //  textBox1.Text = Convert.ToString(cumle.Contains("konusunu"));
            // Insert()
            // textBox1.Text = cumle.Insert(3, "matematik");
            // Remove()
            // textBox1.Text = cumle.Remove(2, 3);
            // Split()
            // textBox1.Text = cumle.Split('.')[1];
            // IndexOf()
            // textBox1.Text = Convert.ToString(cumle.IndexOf("com"));
            // Padleft(), PadRight
            //  textBox1.Text = cumle.PadLeft(61,'w');
            // Substring()
            // textBox1.Text = cumle.Substring(3);
            // Join()
            //  string[] a = {"mat","ve","bil"};
            // textBox1.Text = string.Join("", a);
            //  textBox1.Text = a[0] + " " + a[1] + " " + a[2];

            // a karakteri sayısı
            //int i, aks = 0;
            //string cumle = textBox1.Text;
            //for (i = 0; i < cumle.Length; i++)
            //    if (cumle.Substring(i, 1) == "a") aks++;
            //label1.Text = "a karakteri sayısı:" + aks;

            // kelime sayısı
            //int i, ks = 1;
            //string cumle = textBox1.Text;
            //for (i = 0; i < cumle.Length; i++)
            //    if (cumle.Substring(i, 1) == " ") ks++;
            //label1.Text = "kelime sayısı:" + ks;

            // kelimeleri alt alta yazdırır
            //label1.Text = "";
            //int i;
            //string cumle = textBox1.Text;
            //for (i = 0; i < cumle.Length; i++)
            //    if (cumle.Substring(i, 1) == " ")
            //        label1.Text += "\n";
            //    else
            //        label1.Text += cumle.Substring(i,1);

            // cümleyi tesrten yazdırır
            //label1.Text = "";
            //int i;
            //string cumle = textBox1.Text;
            //for (i = cumle.Length-1; i >=0; i--)
            //    label1.Text += cumle.Substring(i, 1);

            // ters=düz mü
            //label1.Text = "";
            //int i,k;
            //string cumle = textBox1.Text;
            //k = cumle.Length;
            //for (i = 0; i < k; i++)
            //    if (cumle.Substring(i, 1) != cumle.Substring(k - i - 1, 1)) break;//m==k ece
            //if (i == k)
            //    label1.Text = "Ters düz aynı";
            //else
            //    label1.Text = "Ters düz farklı";

            // iki kelimelik ifadenin kelimelerini yer değiştir
            //label1.Text = "";
            //int i, k, bosluk=0;
            //string cumle = textBox1.Text;
            //k = cumle.Length;
            //for (i = 0; i < k; i++)
            //    if (cumle.Substring(i, 1) == " ") bosluk = i;
            //for (i = bosluk + 1; i < k; i++)
            //    label1.Text += cumle.Substring(i, 1);
            //label1.Text += " ";
            //for (i = 0; i < bosluk; i++)
            //    label1.Text += cumle.Substring(i, 1);

            // Dosyalar

            // System.IO

            // StreamWriter sınıfı
            // StreamWriter nesne_adı=new StreamWriter(dosyaYolu,true/false,Encoding.Default,...);
            // StreamWriter sw1 = new StreamWriter(@"c:\okul\deneme.txt", true, Encoding.Default);
            // StreamWriter sw2 = new StreamWriter("c:\\nokul\\deneme.txt", true, Encoding.Default);
            // StreamWriter sw3 = new StreamWriter("c:\\nokul\\deneme.txt");
            // nesne_adı.WriteLine(değişken1,değişken2,...)
            // close()
            // nesne_adı.Close();

            // StreamReader sınıfı
            // StreamReader nesne_adı=new StreamReader(dosyaYolu,Encoding.Default,...);
            // StreamReader sr1 = new StreamReader(@"c:\okul\deneme.txt", Encoding.Default);
            // StreamReader sr2 = new StreamReader("c:\\nokul\\deneme.txt", Encoding.Default);
            // StreamReader sr3 = new StreamReader("c:\\nokul\\deneme.txt");
            // nesne_adı.ReadLine()
            // close()
            // nesne_adı.Close();

            // Kaydetme
            String ad, soyad, numara;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            numara = textBox3.Text;
            StreamWriter sw = new StreamWriter(@"h:\deneme.txt", true);
            sw.WriteLine(ad + ";" + soyad + ";" + numara);
            sw.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Listeleme
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            string[] satir;
            string okunan;
            StreamReader sr = new StreamReader(@"h:\deneme.txt");
            while ((okunan = sr.ReadLine()) != null)
            {
                satir = okunan.Split(';');
                listBox1.Items.Add(satir[0]);
                listBox2.Items.Add(satir[1]);
                listBox3.Items.Add(satir[2]);
            }
            sr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Numaraya Göre Listeleme
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            string istogr = textBox4.Text;
            string[] satir;
            string okunan;
            StreamReader sr = new StreamReader(@"h:\deneme.txt");
            while ((okunan = sr.ReadLine()) != null)
            {
                satir = okunan.Split(';');
                if (istogr == satir[2])
                {
                    listBox1.Items.Add(satir[0]);
                    listBox2.Items.Add(satir[1]);
                    listBox3.Items.Add(satir[2]);
                }
            }
            sr.Close();
            textBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string istogr = textBox4.Text;
            string[] satir;
            string okunan;
            StreamReader sr = new StreamReader(@"h:\deneme.txt");
            StreamWriter sw = new StreamWriter(@"h:\denemeYedek.txt", true);
            while ((okunan = sr.ReadLine()) != null)
            {
                satir = okunan.Split(';');
                if (istogr == satir[2])
                {
                    String ad, soyad, numara;
                    ad = textBox1.Text;
                    soyad = textBox2.Text;
                    numara = textBox3.Text;
                    sw.WriteLine(ad + ";" + soyad + ";" + numara);

                }
                else
                    sw.WriteLine(okunan);
            }
            sw.Close();
            sr.Close();
            File.Delete(@"h:\deneme.txt");
            File.Move(@"h:\denemeYedek.txt", @"h:\deneme.txt");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string istogr = textBox4.Text;
            string[] satir;
            string okunan;
            StreamReader sr = new StreamReader(@"h:\deneme.txt");
            StreamWriter sw = new StreamWriter(@"h:\denemeYedek.txt", true);
            while ((okunan = sr.ReadLine()) != null)
            {
                satir = okunan.Split(';');
                if (istogr != satir[2])
                    sw.WriteLine(okunan);
            }
            sw.Close();
            sr.Close();
            File.Delete(@"h:\deneme.txt");
            File.Move(@"h:\denemeYedek.txt", @"h:\deneme.txt");
            textBox4.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // ziyaretci sayısı (sayaç)
            int zs;
            StreamReader oku = new StreamReader(@"h:\sayac.txt");
            zs = Convert.ToInt32(oku.ReadLine());
            zs++;
            oku.Close();
            label8.Text = "Sayfayı ziyaret eden sayısı: " + zs;
            StreamWriter yaz = new StreamWriter(@"h:\sayac.txt");
            yaz.WriteLine(zs);
            yaz.Close();
        }
    }
}

