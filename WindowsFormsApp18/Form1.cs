using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // değişkenler(özellikler) ve metotlar
            // yapıcı ve yıkıcı metotlardır
            // class
            //class sınıf_ismi
            //{
            // değişken 1;
            // değişken 2;
            // ...
            // metot 1;
            // metot 2;
            // ...
            //}
            // public, private, protected, internal ve protected internal
            // new 
            // sınıf_adı nesne_adı=new sınıf_adı();
            // matematik m=new matematik();
            // nesne_adı.üye_eleman_adı
            // m.x;
            //mat mat1 = new mat();            
            //mat1.a = 12;
            //mat1.b = 13;
            //mat1.yaz();

            // mat m2 = new mat();

            //mat m1 = new mat();
            //mat m3;
            //m1.a = 23;
            //label1.Text = m1.a.ToString();
            //m3 = m1;
            //label2.Text = m3.a.ToString();
            //m3.a = 43;
            //label3.Text = m1.a.ToString();

            //dort_islem di = new dort_islem();
            //label1.Text = di.topla(23, 61).ToString();


            //orn o = new orn();
            //label3.Text = o.topla(1, 2).ToString();

            //islem isl = new islem();
            //isl.A = 56;
            //label3.Text = isl.A.ToString();

         // ??  orn.

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Yapıcı Metotlar
            // Yıkıcı Metotlar
            // Dispose()
            // ~
            // statik üye elemanlar
            // ram rom
            // sınıf_adı.üye_eleman_adı 
            // static 
            // global
            // math.abs(x)

            //matbil mb = new matbil();
            //label1.Text = mb.a.ToString();
            //label2.Text = mb.b.ToString();

            label3.Text = islem4.topla(2, 56).ToString();
            label3.Text = islem4.cikar(2, 56).ToString();
            label3.Text = islem4.a.ToString();

            islem4 i = new islem4();
            label3.Text = i.c.ToString();

        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    matbilgi mat1 = new matbilgi();
        //    label1.Text = mat1.a.ToString();
        //}
    }
    //class mat
    //{
    //  public int a, b;
    //   public void yaz()
    //    {
    //        MessageBox.Show("Sonuç:" + (a + b));
    //    }
    //}
    //class dort_islem
    //{
    //    public int topla(int x,int y)
    //    {
    //        return x + y;
    //    }
    //    public int cikar(int x, int y)
    //    {
    //        return x - y;
    //    }
    //    public int carp(int x, int y)
    //    {
    //        return x * y;
    //    }
    //    public int bol(int x, int y)
    //    {
    //        return x / y;
    //    }

    //}

    //class orn
    //{
    //    class orn2
    //    {
    //        public int toplam(int x, int y)
    //        {
    //            return x + y;
    //        }
    //    }

    //    public int x=12, y=34;
    //    public int topla(int x,int y)
    //    {
    //        return this.x + y;//sınıfa ait değişkenler
    //      //  return x + y; // metoda ait parametreler
    //    }
    //}

    //class islem
    //{
    //    int a;
    //    int b;
    //    public int A
    //    {
    //        get { return a; }
    //        set { a = value; }
    //    }
    //    public int B
    //    {
    //        get { return b; }
    //        set { b = value; }
    //    }       
    //        }

    //class matbilgi
    //{
    //    public int a, b;
    //    public void yaz()
    //    {
    //        MessageBox.Show("Sonuç:" + (a + b));
    //    }
    //    public matbilgi()
    //    {
    //        a = 2;
    //        b = 34;
    //    }
    //}




    //    class matbil
    //{
    //    public int a, b;
    //    public void yaz()
    //    {
    //        MessageBox.Show("Sonuç:" + (a + b));
    //    }
    //    public matbil()
    //    {
    //        a = 2;
    //        b = 34;
    //    }

    //    public matbil(int a)
    //    {
    //        this.a = a;
    //        b = 0;
    //    }
    //    public matbil(int a,int b)
    //    {
    //        this.a = a;
    //        this.b = b;
    //    }
    //    ~matbil()
    //    {
    //        MessageBox.Show("Yıkıcı Metot Çağrıldı");
    //    }
    //}

     class islem4
    {
        public static int a,b;
      //  public int c, d;

        public static int topla(int x, int y)
        {
            return x + y;
        }
        public static int cikar(int x, int y)
        {
            return x - y;
        }
        public static int carp(int x, int y)
        {
            return x * y;
        }
        public static int bol(int x, int y)
        {
            return x / y;
        }

    }
}
// int x;
// float x;olmaz

// set ve get anahtar sözcükleri

