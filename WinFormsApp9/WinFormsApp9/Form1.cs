namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yil, ay, gun;
            gun = Convert.ToInt32(textBox1.Text);
            ay = Convert.ToInt32(textBox2.Text);
            yil = Convert.ToInt32(textBox3.Text);
            DateTime bugun = DateTime.Today;
            DateTime dt = new DateTime(yil,ay,gun);
            TimeSpan fark = bugun - dt;
            label4.Text = "Doðduðunuz gün: " + dt.DayOfWeek;
            label5.Text = "Geçen gün sayýsý: " + fark.Days;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int gs = Convert.ToInt32(textBox1.Text);
            TimeSpan fark = new TimeSpan(gs,0,0,0);
            DateTime dt = DateTime.Today + fark;
            label4.Text = dt.DayOfWeek.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int yil1, ay1, gun1, yil2, ay2, gun2;
            gun1 = Convert.ToInt32(textBox1.Text);
            ay1 = Convert.ToInt32(textBox2.Text);
            yil1 = Convert.ToInt32(textBox3.Text);
            gun2 = Convert.ToInt32(textBox4.Text);
            ay2 = Convert.ToInt32(textBox5.Text);
            yil2 = Convert.ToInt32(textBox6.Text);
            DateTime t1 = new DateTime(yil1,ay1,gun1);
            DateTime t2 = new DateTime(yil2, ay2, gun2);
            TimeSpan fark = t2 - t1;
            int hss = 0;
            DateTime gecici;
            for (int i=0;i<=fark.Days;i++)
            {
                gecici = t1.AddDays(i);
                if (gecici.DayOfWeek==DayOfWeek.Sunday || gecici.DayOfWeek==DayOfWeek.Saturday)
                    hss++;
            }
            label5.Text = "Gün Sayýsý:" + hss;
            //ms sql
        }
    }
}// try catch finally