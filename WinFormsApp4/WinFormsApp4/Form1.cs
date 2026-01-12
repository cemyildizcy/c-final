namespace WinFormsApp4
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
            int s1, s2;
            if (textBox1.Text == "" || textBox2.Text == "")
                label3.Text = "Textbox lar boþ olamaz";
            else
            {
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                if (radioButton1.Checked)
                    label3.Text = "Sonuç=" + topla(s1, s2);
                else if (radioButton2.Checked)
                    label3.Text = "Sonuç=" + cikar(s1, s2);
                else if (radioButton3.Checked)
                    label3.Text = "Sonuç=" + carp(s1, s2);
                else if (radioButton4.Checked)
                    if (s2 == 0)
                        label3.Text = "sýfýra bölme yapýlamaz.";
                    else
                        label3.Text = "Sonuç=" + bol(s1, s2);
                else
                    label3.Text = "Lütfen seçim yapýnýz.";
            }
        }
        private double topla(int s1,int s2)
        {
            return s1 + s2;
        }
        private double cikar(int s1, int s2)
        {
            return s1 - s2;
        }
        private double carp(int s1, int s2)
        {
            return s1 * s2;
        }
        private double bol(int s1, int s2)
        {
            return s1 / s2;
        }
    }
}