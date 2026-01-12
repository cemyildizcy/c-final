namespace WinFormsApp6
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
            // exp(x)
            double sonuc = 0;
            double x = Convert.ToDouble(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i <=n; i++)
            {
                sonuc += Math.Pow(x, i) / faktoriyel(i);
            }
            label3.Text = sonuc.ToString();
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