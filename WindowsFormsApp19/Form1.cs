using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using matbil;
//using fen5;
//using fen5.bolum;
//using fen5.bolum.matematik;
//using matbil1;
//using matbil2;
//using d1 = matbil1.mat;
//using d2 = matbil2.mat;
//using fen;
//using fen.bolum;


namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // namespace - isim alanları - isim uzayı
            // c++ paket(package)
            // vc# namespace
            //  MessageBox.Show("örnektir");
            // int32 a;
            //  System.Windows.Forms.MessageBox.Show("Örnektir.");

            // mat m = new mat();
            //  bil b = new bil();

            //matbil.mat m = new matbil.mat();
            //matbil.bil n= new matbil.bil();

            // mat m = new mat();
            // label1.Text = m.topla(45,91).ToString();

            //fen5.bolum.matematik.mat m1 = new fen5.bolum.matematik.mat();
            //label1.Text = m1.topla(45, 91).ToString();

            // mat m5 = new mat();
            //matbil1.mat m6 = new matbil1.mat();
            //matbil2.mat m7 = new matbil2.mat();


            //d1 m8 = new d1();
            //d2 m9 = new d2();
            //m8.topla(34, 89);
            //m9.cikar(56, 98);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // System
            // DateTime ve TimeSpan
            // label1.Text = DateTime.MinValue.ToString();
           // label1.Text = DateTime.MaxValue.ToString();

            // Now ve Today

             //label1.Text = DateTime.Now.ToString();
            // label1.Text = DateTime.Today.ToString();

            // date
            // month
            // day
            // year
            // dayofweek
            // dayofyear
            // timeofday
            // hour
            // minute
            // second
            // millisecond

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int y, a, g;
            y = Convert.ToInt32(textBox1.Text);
            a = Convert.ToInt32(textBox2.Text);
            g = Convert.ToInt32(textBox3.Text);
            DateTime bugun = DateTime.Today;           
            DateTime dt = new DateTime(y,a,g);
            TimeSpan fark = bugun - dt;
            label4.Text = "Doğduğunuz Gün:" + dt.DayOfWeek;
            label5.Text = "Geçen Gün Sayısı:" + fark.Days;
        }
    }
}

// namespace isimalanı_adı
// {
// ...
// }

//namespace matbil
//{
//    class mat
//    {

//    }
//    class bil
//    {

//    }
//}
// fen.bolum.orn o=new fen.bolum.orn();
//namespace fen
//{
//    namespace bolum
//    {
//        class orn
//        {

//        }

//    }
//    class mat
//    {

//    }
//    class bil
//    {

//    }
//}
// fen5.bolum.matematik
// 1. yol using ile projeye eklemek
// 2.yol tam isim kullanmak

//namespace fen5
//{
//    namespace bolum
//    {
//        namespace matematik
//        {
//            class mat
//            {
//                public int topla(int x,int y)
//                {
//                    return x + y;
//                }
//            }
//            class bil
//            {

//            }

//        }
//    }
//    namespace abd
//    {

//    }
//}

//namespace matbil1
//{
//    class mat
//    {
//        public int topla(int x, int y)
//        {
//            return x + y;
//        }
//    }
//}

//namespace matbil2
//{
//    class mat
//    {
//        public int cikar(int x, int y)
//        {
//            return x - y;
//        }
//    }
//}
