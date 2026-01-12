namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int sayi1, sayi2;
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                if (radioButton1.Checked)
                    label2.Text = topla(sayi1, sayi2).ToString();
                else if (radioButton2.Checked)
                    label2.Text = cikar(sayi1, sayi2).ToString();
                else if (radioButton3.Checked)
                    label2.Text = carp(sayi1, sayi2).ToString();
                else if (radioButton4.Checked)
                {
                    if (sayi2 != 0)
                        label2.Text = bol(sayi1, sayi2).ToString();
                    else
                        label2.Text = "2. sayý sýfýr olamaz";
                }
                else
                    label2.Text = "Seçim Yapýnýz";
            }
            else
                label2.Text = "Tüm alanlarý doldurunuz";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        int topla(int a,int b)
        {
            return a + b;
        }
        int cikar(int a, int b)
        {
            return a - b;
        }
        int carp(int a, int b)
        {
            return a * b;
        }
        int bol(int a, int b)
        {
            return a / b;
        }
    }
}