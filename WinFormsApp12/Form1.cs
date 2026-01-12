namespace WinFormsApp12
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
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int s1, s2, sonuc;
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                if (radioButton1.Checked)
                {
                    sonuc = s1 + s2;
                    label3.Text = sonuc.ToString();
                }
                else if (radioButton2.Checked)
                {
                    sonuc = s1 - s2;
                    label3.Text = sonuc.ToString();
                }
                else if (radioButton3.Checked)
                {
                    sonuc = s1 * s2;
                    label3.Text = sonuc.ToString();
                }
                else if (radioButton4.Checked)
                {
                    sonuc = s1 / s2;
                    label3.Text = sonuc.ToString();
                }
                else
                    label3.Text = "Lütfen seçim yapýnýz";
            }
            else
                label3.Text = "Lütfen tüm alanlarý doldurunuz";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}