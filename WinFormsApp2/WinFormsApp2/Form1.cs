namespace WinFormsApp2
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
            label2.Text = "";
            int sayi,i,j;
            if (textBox1.Text == "")
                label2.Text = "textbox1 boþ olmamalý";
            else
            {
                int n = Convert.ToInt32(textBox1.Text);
                int[] dizi = new int[n + 1];
                for (i = 1; i <= n; i++)
                {
                    dizi[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(i+". elemaný gininiz","Dizi Giriniz","", 10,10));
                }
                for (i = 1; i <= n-1; i++)
                {
                    for (j = i+1; j <= n; j++)
                    {
                        if (dizi[i] < dizi[j])
                        {
                            sayi = dizi[i];
                            dizi[i] = dizi[j];
                            dizi[j] = sayi;
                        }
                    }
                }
                for (i = 1; i <= n; i++)
                {
                    label2.Text += dizi[i]+"\n";
                }
            }
        }
    }
}