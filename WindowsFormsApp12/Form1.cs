using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
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
            s1 =Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            sonuc = s1 + s2;
            label3.Text ="Sonuç=" + Convert.ToString(sonuc);
            // kontrol_adı.özellik

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Günaydınlar");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text += "deneme";//label3.Text = label3.Text+"deneme"
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("Çorum");
            listBox1.Items.Add("Kırıkkale");
            listBox1.Items.Add("Amasya");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s1, s2, sonuc=0;
            if (textBox1.Text!="" && textBox2.Text != "")
            {
                groupBox1.Visible = true;
                s1 = Convert.ToDouble(textBox1.Text);
                s2 = Convert.ToDouble(textBox2.Text);
                if (radioButton1.Checked)
                {
                    sonuc = s1 + s2;
                    label3.Text = "Sonuç=" + Convert.ToString(sonuc);
                }
                else if (radioButton2.Checked)
                {
                    sonuc = s1 - s2;
                    label3.Text = "Sonuç=" + Convert.ToString(sonuc);
                }
                else if (radioButton3.Checked)
                {
                    sonuc = s1 * s2;
                    label3.Text = "Sonuç=" + Convert.ToString(sonuc);
                }
                else if (radioButton4.Checked)
                {
                    sonuc = s1 / s2;
                    label3.Text = "Sonuç=" + Convert.ToString(sonuc);
                }
                else
                    label3.Text = "Lütfen seçim yapınız.";
            }
            else
                label3.Text = "Lütfen tüm alanları doldurunuz.";
            
        }
    }
}
