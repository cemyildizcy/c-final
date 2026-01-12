namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          topla(4, 6);
        }
        private void topla(int a,int b)
        {
            int sonuc = a + b;
            MessageBox.Show("Sonuç="+sonuc,"Void örneði");
        }
    }
}