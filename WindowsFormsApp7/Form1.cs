using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
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
            int s1, s2, sonuc=0;
            if (textBox1.Text == "" || textBox2.Text == "")
                label3.Text = "Tüm alanlar doldurulmalı";
            else
            {
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                if (radioButton1.Checked)
                    sonuc = s1 + s2;
                else if (radioButton2.Checked)
                    sonuc = s1 - s2;
                else if (radioButton3.Checked)
                    sonuc = s1 * s2;
                else if (radioButton4.Checked)
                    sonuc = s1 / s2;
                else
                    label3.Text = "Seçim yapınız";
                label3.Text = "Sonuç=" + sonuc;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                label3.Text = "Tüm alanlar doldurulmalı";
            else
            {
                int s1, s2, sonuc;
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                sonuc = s1 + s2;
                label3.Text = "Sonuç=" + sonuc.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("İlk Program");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Düzce");
            comboBox1.Items.Add("Çorum");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Değişkenler

            // Değer tipleri - değişkenin değeri doğrudan bellekte saklanır (stack-yığın)
            // referans tipler - değişkenin adresi bellekte saklanır, değeri heap-öbek bölgesinde tutulur

            // Değer tipleri
            // byte veri türü
            // 8 bitlik 2^8=256
            // 0..255
            // byte a=2;
            // byte b=45;
            // byte c = 34, d = 228;
            // sbyte veri türü
            // -128 ile 127
            // sbyte aa = 34;
            //  byte a1 = 45;
            // byte sayi_topla = 45;
            //byte sayiToplaYaz = 34;
            // short veri türü -32768..32767
            // ushort 0..65535
            // int veri türü -2^31..2^31-1
            // uint 0..2^32-1
            // long veri türü -2^63..2^63-1
            // ulong 0..2^64-1
            //long x = 34; // 80b
            //byte y = 3;  // 10b

            // byte a = 34, b = 45,c;
            //c = a + b;

            // float 
            // float a = 5.1f;
            //float b = 4.5F;
            // double
            // double c = 6.1d;
            // double d=55.67D;
            // double e = 567.345;

            //double x = a + b;
            // label3.Text = x.ToString();

            // float y = 2.3;

            // decimal
            //decimal a1 = 3.12m;
            // decimal a2 = 45.87M;

            // bool veri türü
            // true veya false

            //  bool b1 = false;
            //  bool b2 = true;
            // int aa = 45;
            //  bool b3 = aa < 61;
            //  label3.Text = b3.ToString();

            // char veri türü
            // 16 bit Unicode

            // ascii 256 A a ■ Çü╚
            // charset
            // unicode

            // char c1 = 'A';
            // char c2 = (char)78;
            // char c3 = '\u0061';
            // label3.Text = c1.ToString();
            //  label3.Text = c2.ToString();
            // label3.Text = c3.ToString();

            // referans türler
            // string veri türü
            // unicode 
            // ""
            //  string a = "Görsel";
            // string b = "Programlama II";
            //  string c = a + " " + b;
            //  label3.Text = c;

            // string dosya1 = "C:\\okul\\deneme.txt";
            // veya
            // string dosya2 = @"C:\okul\deneme.txt";

            //  string a = "deneme";
            //  int b = 61;
            //  label3.Text = a + b.ToString();
            //  b = 102;

            // object veri türü

            // object a;//var
            // a = 5;
            //  label4.Text = a.GetType().ToString();
            //  a = 'A';
            //  label6.Text = a.GetType().ToString();
            // a = 15.2;
            //  label7.Text = a.GetType().ToString();
            //  a = true;
            //  label8.Text = a.GetType().ToString();
            //  a = 45.7m;
            // label9.Text = a.GetType().ToString();

            // Tür Dönüşümü
            // Bilinçsiz tür dönüşümü ve bilinçli tür dönüşümüdür

            // Bilinçsiz tür dönüşümü


            //  byte a = 12;
            //  int b;
            //  b = a;
            // label9.Text = b.ToString();

            //  int c = 23;
            //  byte d;
            // d = c;

            //  float a = 3.4f;

            //  double b = 3.5f;

            // Bilinçli tür dönüşümü
            // ()
            // byte a = 34;
            // int b = (int)a;

            // int c = 255;
            // byte d = (byte)c;
            // label9.Text = d.ToString();

            // XXXXXXXX XXXXXXXX XXXXXXXX XXXXXXXX 4byte
            // XXXXXXXX 1byte

            // 00000000 00000000 00000001 00000000 int olarak 256 nın bellekteki görünümü
            // checked - unchecked

            // int c = 256;
            //  byte d,a;
            //  checked
            // {
            //    d = (byte)c;
            //    unchecked
            //    {
            //        a = (byte)c;
            //    }
            //  }
            // label9.Text = d.ToString();

            // int a = 23;
            // label1.Text = Convert.ToString(a);
            // a = 34;

            // Operatörler
            // + - * / % ++ --

            //  int a = 34;
            // if (a % 2 != 0)
            //     label1.Text = "Sayı tektir";
            //  else
            //     label1.Text = "sayı çifttir";
            //  int a =29;
            //  a = ++a; a++ a=a+1
            //  a = a++;
            //  label1.Text = (++a).ToString();

            // <, >, <=, >=, ==, != eşit değil
            // = ==
            // || veya,  && ve
            // =, +=, -=, *=, /=, %=
            // a=2;
            // a+=6; a=a+6;
            // a-=5, a=a-5
            // label1.Text += " giriniz:";

            // () [] ?:
            //koşul?işlem1:işlem2

            // int x=2;
            // string y = "kalem";
            // y = y + (x==1?"":"ler");
            // label1.Text = y;

            // int a = 1 + 2 * 4 / 2 + (3-2*(3+5));
            //  label1.Text = a.ToString();

            //  int b =(int)(1 / 2.0);
            //  label2.Text = b.ToString();

            //  double c = 1 / 2.0;
            //   label3.Text = c.ToString();

            // double c = Math.Pow(5,4);
            // label3.Text = c.ToString();

            // Karar Yapıları
            // if ve switch
            // if koşul ifadesi
            // if (koşul) yapılacak işlem


            // if (sayi <= 61) {MessageBox.Show("Sayı uygun değil")};

            // if (koşul1)
            //{
            // koşul1 sağlanınca yapılacak işlemler
            //}
            // else if (koşul2)
            //{
            // koşul2 sağlanınca yapılacak işlemler
            //}
            // else
            //{
            // koşullar sağlanmayınca yapılacak işlemler
            //}

            double sayi = 10;
            double sonuc;
            if (sayi > 0)
            {
                sonuc = Math.Pow(sayi,3);
                label1.Text = sonuc.ToString();
            }
            else if (sayi==0)
            {
                sonuc = Math.Cos(Math.PI/3);
                label1.Text = sonuc.ToString();
            }
            else
            {
                sonuc = Math.Abs(sayi);
                label1.Text = sonuc.ToString();
            }
            label1.Text = sonuc.ToString();

           // switch koşul ifadesi
        }
    }
}
