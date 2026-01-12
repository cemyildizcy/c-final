namespace WinFormsApp11
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
            int s1, s2, sonuc;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            sonuc = s1 + s2;
            label3.Text ="Sonuç="+Convert.ToString(sonuc);
           // label3.Text = sonuc.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "Merhaba Dünya";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Merhaba";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}