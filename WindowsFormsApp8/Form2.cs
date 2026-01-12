using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            int r = Convert.ToInt32(textBox3.Text);
            int[,] A = new int[n + 1, m + 1];
            int[,] B = new int[m + 1, r + 1];
            int[,] C = new int[n + 1, r + 1];
            int i, j, k, t;
            string satir1 = "", satir2 = "", satir3 = "";
            for (i = 1; i < n + 1; i++)
            {
                for (j = 1; j < m + 1; j++)
                {
                    A[i, j] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("A[" + i + "," + j + "] i giriniz:", "Matris Girdisi", "", 10, 10));
                    satir1 += A[i, j] + " ";
                }
                listBox1.Items.Add(satir1);
                satir1 = "";
            }
            for (i = 1; i < m + 1; i++)
            {
                for (j = 1; j < r + 1; j++)
                {
                    B[i, j] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("B[" + i + "," + j + "] i giriniz:", "Matris Girdisi", "", 10, 10));
                    satir2 += B[i, j] + " ";
                }
                listBox2.Items.Add(satir2);
                satir2 = "";
            }
            for (i = 1; i < n + 1; i++)
            {
                for (j = 1; j < r + 1; j++)
                {
                    t = 0;
                    for (k = 1; k < m + 1; k++)
                        t += A[i, k] * B[k, j];
                    C[i, j] = t;
                    satir3 += C[i, j] + " ";
                }
            listBox3.Items.Add(satir3);
            satir3 = "";
            }
            // Metotlar
            // [erişim belirteçleri] <geri dönüş değeri> metot ismi(parametre listesi)
            // {
            // metot gövdesi
            // }
            // public, private, ...
          label1.Text= topla(2, 3).ToString();
        }
        private int topla(int a, int b)
        {
            return a + b;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
