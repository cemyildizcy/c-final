using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
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

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("İlk program");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text += "deneme";//label3.Text = label3.Text+"deneme";
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, sonuc;
            s1 =Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            // kontrol_adı.özellik
            sonuc = s1 + s2;
            label3.Text ="Sonuç="+ Convert.ToString(sonuc);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Çorum");
            comboBox1.Items.Add("Kırıkkale");
            comboBox1.Items.Add("Amasya");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text!="")
            {
                double s1,s2,sonuc = 0;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
