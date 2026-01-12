using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int i, bs = 0;
            string cumle = textBox1.Text;
            for (i = 0; i < cumle.Length; i++)
                if (cumle.Substring(i, 1) == "b" || cumle.Substring(i, 1) == "B")
                    bs++;
            label2.Text = "Cümledeki b karakteri sayısı:" + bs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, ks = 1;
            string cumle = textBox1.Text;
            for (i = 0; i < cumle.Length; i++)
                if (cumle.Substring(i, 1) == " ")
                    ks++;
            label2.Text = "Cümledeki kelime sayısı:" + ks;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int i;
            string cumle = textBox1.Text;
            for (i = 0; i < cumle.Length; i++)
                if (cumle.Substring(i, 1) == " ")
                    label2.Text += "\n";
            else
                    label2.Text += cumle.Substring(i,1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int i;
            string cumle = textBox1.Text;
            for (i = cumle.Length-1; i >=0 ; i--)
                    label2.Text += cumle.Substring(i, 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int i,ks;
            string cumle = textBox1.Text;
            ks = Convert.ToInt32(cumle.Length);

            for (i = 0; i < ks; i++)
                if (cumle.Substring(i, 1) != cumle.Substring(ks-i-1, 1)) break;
            if (i==ks)
                label2.Text = "Cümle tersi ile aynı";
            else
                label2.Text = "Cümle tersi ile aynı değil";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int i, bosluk=0;
            string cumle = textBox1.Text;
            for (i = 0; i < cumle.Length; i++)
                if (cumle.Substring(i, 1) == " ") bosluk=i;
            for (i = bosluk+1; i < cumle.Length; i++)
                label2.Text += cumle.Substring(i,1);
            label2.Text += " ";
            for (i = 0; i < bosluk; i++)
                label2.Text += cumle.Substring(i, 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string ad, no, s, b;
            ad = textBox1.Text;
            no = textBox2.Text;
            s = textBox3.Text;
            b = textBox4.Text;
            string ds = @"c:\dosya\ogrenciler.txt";
            StreamWriter sw = new StreamWriter(ds,true);
            sw.WriteLine(ad+";"+no+";"+s+";"+b);
            sw.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            string[] satir;
            string ds = @"c:\dosya\ogrenciler.txt";
            StreamReader sr = new StreamReader(ds);
            string okunan;
            while((okunan=sr.ReadLine())!=null)
            {
                satir = okunan.Split(';');
                listBox1.Items.Add(satir[0]);
                listBox2.Items.Add(satir[1]);
                listBox3.Items.Add(satir[2]);
                listBox4.Items.Add(satir[3]);
            }
            sr.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string arananOgrenci = textBox5.Text;
            string[] satir;
            string ds = @"c:\dosya\ogrenciler.txt";
            string dsYedek = @"c:\dosya\ogrencilerYedek.txt";
            StreamReader sr = new StreamReader(ds);
            StreamWriter sw = new StreamWriter(dsYedek,true);
            string okunan;
            while ((okunan = sr.ReadLine()) != null)
            {
                satir = okunan.Split(';');
                if (arananOgrenci == satir[1])
                {
                    string ad, no, s, b;
                    ad = textBox1.Text;
                    no = textBox2.Text;
                    s = textBox3.Text;
                    b = textBox4.Text;
                    sw.WriteLine(ad + ";" + no + ";" + s + ";" + b);
                }
                else
                    sw.WriteLine(okunan);
            }
            sw.Close();
            sr.Close();
            File.Delete(ds);
            File.Move(dsYedek,ds);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string arananOgrenci = textBox5.Text;
            string[] satir;
            string ds = @"c:\dosya\ogrenciler.txt";
            string dsYedek = @"c:\dosya\ogrencilerYedek.txt";
            StreamReader sr = new StreamReader(ds);
            StreamWriter sw = new StreamWriter(dsYedek, true);
            string okunan;
            while ((okunan = sr.ReadLine()) != null)
            {
                satir = okunan.Split(';');
                if (arananOgrenci != satir[1])
                    sw.WriteLine(okunan);
            }
            sw.Close();
            sr.Close();
            File.Delete(ds);
            File.Move(dsYedek, ds);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string arananOgrenci = textBox5.Text;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            string[] satir;
            string ds = @"c:\dosya\ogrenciler.txt";
            StreamReader sr = new StreamReader(ds);
            string okunan;
            while ((okunan = sr.ReadLine()) != null)
            {
                satir = okunan.Split(';');
                if (arananOgrenci == satir[1])
                {
                listBox1.Items.Add(satir[0]);
                listBox2.Items.Add(satir[1]);
                listBox3.Items.Add(satir[2]);
                listBox4.Items.Add(satir[3]);
                }
            }
            sr.Close();
        }
    }
}
