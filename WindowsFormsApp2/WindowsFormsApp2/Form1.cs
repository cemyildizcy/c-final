using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Close();
            // olaylar events
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text += "ComboBox";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i=12;
            label1.Text += i.ToString();
            // label1.Text = Convert.ToString(i);
            string a="orn1", b="orn2",c;
            int a1=12, b1=23,c1;
            c = a + b;
            c1 = a1 + b1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Günaydın","Örnek");
        }
    }
}
