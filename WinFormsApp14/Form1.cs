

namespace WinFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int g, a, y;
            //g = Convert.ToInt32(textBox1.Text);
            //a = Convert.ToInt32(textBox2.Text);
            //y = Convert.ToInt32(textBox3.Text);
            //DateTime bugun = DateTime.Today;
            //DateTime dt = new DateTime(y,a,g);
            //TimeSpan fark = bugun - dt;
            //label4.Text = "Doðduðunuz Gün:" + dt.DayOfWeek;
            //label5.Text = "Geçen Gün Sayýsý:" + fark.Days;

            //int gsayisi;
            //gsayisi= Convert.ToInt32(textBox1.Text);
            //TimeSpan fark = new TimeSpan(gsayisi,0,0,0);
            //DateTime dt = DateTime.Today + fark;
            //label5.Text = dt.DayOfWeek.ToString();


            int g1, a1, y1, g2, a2, y2;
            g1 = Convert.ToInt32(textBox1.Text);
            a1 = Convert.ToInt32(textBox2.Text);
            y1 = Convert.ToInt32(textBox3.Text);
            g2 = Convert.ToInt32(textBox4.Text);
            a2 = Convert.ToInt32(textBox5.Text);
            y2 = Convert.ToInt32(textBox6.Text);
            DateTime t1 = new DateTime(y1, a1, g1);
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
            label5.Text = "Hafta sonu sayýsý:" + hss;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            // tarih ve zaman iþlemleri
            // system DateTime, TimeSpan
        }
    }
}