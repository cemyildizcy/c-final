using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // veri türleri
            // değişken tür tip
            // 1 değer tipleri
            // 2 referans tipler

            // değer tipleri
            // byte sbyte
            // short ushort
            // int uint
            // long ulong
            // 8bit=1byte 2^8
            // 0 ile 255
            // -128 ile 127 
            // 0 ile 65535
            // int -2^31 ile (2^31)-1
            // uint 0 ile (2^32)-1
            // long -2^63 ile (2^63)-1
            // ulong 0 ile (2^64)-1
            //    byte a;
            //    a = 34;
            //    // veya
            //    byte b = 21;
            //    byte x, y, z;
            //    x = 67;y = 34;z = 78;
            //    // veya
            //    byte xx=1, yy=29, zz=67;
            //  // z=x+y;// = atama operatörü
            //    int a1=98, a2=56,a3=56;
            //    a3 = a1 + a2;
            //  //  z = 256;// sınırlar aşıldı

            //    // float, double, decimal
            //    // float f veya F
            //    float a5 = 2.3f;
            //    float a6 = -90.4563F;
            //    // d veya D
            //    double a7 = 23;
            //    double a8 = 23.23;
            //    double a9 = 25.2d;
            //    double a10 = 239.2134D;
            //    // decimal
            //    // m veya M
            //    decimal b1 = 23.89m;
            //    decimal b2 = 98.12M;
            //    // int 
            //    // double
            //    // byte a,b,c,d,e; toplam 5byte
            //    // long  a1,b1,c1,d1,e1; 40byte
            //    // 1a geçersiz
            //    // a b geçersiz
            //    // ab veya a_b geçerli

            //    // bool  true false

            //    bool x1 = false;
            //    int x3 = 61;
            //    bool x4 = x3 < 60;
            //    bool x2 = true;
            //    label1.Text = Convert.ToString(x4);

            //    // char veri türü
            //    // char 16bit uzunluğunda evrensel bir karakter kod olan
            //    // unicode standartlarındaki karakterleri temsil etmek için kullanılır
            //    // ascii charset unicode
            //    // 256    alt+65+32
            //    // 32  
            //    // charset
            //    // 128 128
            //    // unicode 65536
            //    char c1 = 'A';
            //    char c2 = (char)90;
            //    char c3 = '\u0058';
            //    label1.Text = c3.ToString();
            //    // '' char, "" string
            //    // 13 değer tipleri

            //    // referans tipler
            //    // string ve object
            //    // string veri türü

            //    string z1 = "VC#";
            //    string z2 = "Nesne Yönelimli bir dildir.";
            //    string z3 = z1 +" "+z2;
            //    label1.Text = z3;
            //    // object veri türü

            //    object ts1,ts2;
            //    ts1 = 5;
            //   // label1.Text = Convert.ToString(ts1.GetType());
            //    ts2 = 'A';
            //   // label1.Text = Convert.ToString(ts1.GetType());
            //    ts1 = 11.61f;
            //   //  label1.Text = Convert.ToString(ts1.GetType());
            //    ts1 = true;
            //   // label1.Text = Convert.ToString(ts1.GetType());
            //    ts1 = 66.77m;
            //    // label1.Text = Convert.ToString(ts1.GetType());

            //    //  object ts3= ts1+ts2;
            //  //  string yol1 = "d:\\nokul\\ornek.txt";
            //   // string yol2 = @"d:\nokul\ornek.txt";
            // // "\n"



            //  // Tür Dönüşümleri
            //byte xx1 = 23;
            //int xx2 = 45;
            //int xx3;
            //    //bilinçsiz tür dönüşümü
            //    //bilinçli tür dönüşümü

            //    //bilinçsiz tür dönüşümü

            //xx3 = xx1 + xx2;
            //xx2 = xx1;

            //xx1 = xx2;

            //float a = 25.9f;
            //double b = 34;
            //a = b;
            //b = a;

            //bilinçli tür dönüşümü
            // ()
            // (dönüştürülecek_tür) değişken veya sabit
            // byte a = 10;
            // int b=256;
            ////  int c=(int)a;// int c = a;


            // a =(byte) b;//doğru
            //// a = b //hatalı;
            // label1.Text = a.ToString();

            // XXXXXXXX 1byte byte            
            // XXXXXXXX XXXXXXXX XXXXXXXX XXXXXXXX 4byte int
            // 00000000 00000000 00000001 00000000 256


            // XXXXXXXX XXXXXXXX 2byte short
            // XXXXXXXX XXXXXXXX XXXXXXXX XXXXXXXX XXXXXXXX XXXXXXXX XXXXXXXX XXXXXXXX 8byte long

            // checked ve unchecked anahtar sözcükleri

            //int a = 256;
            //byte b;
            //b = (byte)a;
            //checked
            //{
            //    b = (byte)a;
            //}
            //label1.Text = b.ToString();

            //int a = 256;
            //int b = 455;
            //byte c, d;
            //checked
            //{
            //    c = (byte)a;
            //    unchecked
            //    {
            //        d = (byte)b;
            //    }
            //}
            //label1.Text = b.ToString();

            // ToString()

            //int a1 = 34;
            //string a2 = a1.ToString();
            //string a3 = "23";
            //string a4 = a1+a3;

            //string a5 = a1 + a3;
            //label1.Text = a4;

            // Convert sınıfı
            //char a =(char) 61;
            //bool b = Convert.ToBoolean(a);
            //label1.Text = Convert.ToString(b);
            //  label1.Text = b.ToString();
            //string dd = "23";
            //int cc = int.Parse(dd);//veya
            // int ee = Convert.ToInt32(dd);


            //double b = 1.2;
            //double a = 1/3.0;
            //label1.Text = a.ToString();

            // operatörler
            // + - * / % < <= > >= != eşit değil == eşittir
            // ++ -- += -= *= /= && ve || veya ?: koşul operatörü
            // = atama operatörü

            //int a = 34, b = 3, c;
            //label1.Text = (a % b).ToString();

            //int sayi = Convert.ToInt32(textBox1.Text);
            //if (sayi % 2 == 0)
            //    label1.Text = "sayı çifttir";
            //else
            //    label1.Text = "sayı tektir";


            // int a = 34, b = 6, c = 78;
            //label1.Text = (a++).ToString();
            //label2.Text = a.ToString();

            // a++ a=a+1
            // a-- a=a-1
            //  b = a++;
            // c = ++a;
            // b += 2;// b=b+2;
            // c -= 2; // c=c-2;
            // c /= 5; // c=c/5;
            //  label1.Text = b.ToString();
            //  label2.Text = c.ToString();


            // 3^5,3 ** 5;
            // double x=1+2*45/5+((23+(45-56))
            // 2-4*5+(3*6/2-3*(4+2)) 
            // 2+3-(4*5)^2
            // double q = 2 ^ 2;// üs alma operatörü değildir
            // label2.Text = q.ToString();
            // pow(a,b) a^b
            // double c =Math.Pow(2,5);
            // int d = Math.Pow(2, 5); // hatalı
            //int sayi = Convert.ToInt32(textBox1.Text);
            //string sonuc = "kalem";
            //sonuc = sonuc + (sayi==1?" ": "ler");
            //label1.Text = sonuc.ToString();

            // karar yapıları
            // if ve switch
            // if karar yapısı
            // if (koşul) işlem;
            // veya
            // if (koşul)
            // işlem


            //int a = 1;
            //if (a == 2) label1.Text = "if için örnektir";


            // veya
            //if (a == 2) 
            //    label1.Text = "if için örnek1";
            //label2.Text = "if için örnek2";


            //

            //if (a == 2)
            //{
            //    label1.Text = "if için örnek1";
            //    label2.Text = "if için örnek2";
            //}

            //if (a == 2)
            //{
            //    label1.Text = "if için örnek1";
            //    label2.Text = "if için örnek2";
            //}

            // if (koşul)
            // {
            // koşul sağlanınca yapılacak işlem(ler)
            // }
            // else
            // {
            // koşul sağlanmayınca yapılacak işlem(ler)
            // }

            //int x = 6;
            //double f;
            //if (x <= 25)
            //    f = Math.Pow(x, 5);
            //else
            //    f = Math.Cos(Math.PI / 3);
            //label1.Text = f.ToString();

            // if (koşul1)
            // {
            // koşul1 sağlanınca yapılacak işlem(ler)
            // }
            // else if (koşul2)
            // {
            // koşul2 sağlanınca yapılacak işlem(ler)
            // }
            // else if (koşul3)
            // {
            // koşul3 sağlanınca yapılacak işlem(ler)
            // }
            // else
            // {
            // koşul1-2-3 sağlanmayınca yapılacak işlem(ler)
            // }

            int x = Convert.ToInt32(textBox1.Text);
            double f;
            if (x< 23)
                f = x * x;
            else if (x == 23)
                f = Math.Sqrt(x);
            else
                f = Math.Abs(x);
            label1.Text = f.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
