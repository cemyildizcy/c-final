using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ?:operatörü
            // koşul ? koşul sağlanıyorsa yapılacak işlem : koşul sağlanmıyorsa y i

            int a;
            a = Convert.ToInt32(textBox1.Text);
            string cumle = "Kalem";
            cumle = cumle + (a==1 ? " tek" : "ler");
            label2.Text = cumle;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
