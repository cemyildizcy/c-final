namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m, n;
            double sonuc;
            m = Convert.ToInt32(textBox1.Text);
            n = Convert.ToInt32(textBox2.Text);
            if (m >= n)
            {
                sonuc = (double)faktoriyel(m) / (faktoriyel(n) * faktoriyel(m - n));
                label3.Text = "Sonuç=" + sonuc;
            }
            else
                label3.Text = "n, m den büyük olamaz.";
        }
        private int faktoriyel(int sayi)
        {
            int carp = 1;
            for (int i = 1; i <= sayi; i++)
                carp *= i;
            return carp;
        }
    }
}