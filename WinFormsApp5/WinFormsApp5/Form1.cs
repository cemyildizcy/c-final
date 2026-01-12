namespace WinFormsApp5
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
            int sayi;
            int n = Convert.ToInt32(textBox1.Text);
            for (int i=1;i<=n;i++)
            {
                sayi = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(i+". Sayýyý Giriniz:","Sayý Giriþi","",10,10));
                listBox1.Items.Add(sayi+"!="+faktoriyel(sayi));
            }
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