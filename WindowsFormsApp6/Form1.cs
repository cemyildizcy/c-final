using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // SqlConnection nesne_adı=new SqlConnection
            // ("Data Source=sunucu_adı veya IP si;Initial Catalog=veritabanı_adı;
            // Integrated Security=True");


            // SqlConnection nesne_adı=new SqlConnection
            // ("Server=sunucu_adı veya IP si;database=veritabanı_adı;
            // Integrated Security=True");


            // SqlConnection nesne_adı=new SqlConnection
            // ("Data Source=sunucu_adı veya IP si;Initial Catalog=veritabanı_adı;Uid=kullanıcı_adı;Pwd=şifre");

            // Örnek

            // SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ogrenci;Integrated Security=True");
            // SqlConnection baglanti1 = new SqlConnection("Data Source=193.140.255.122;Initial Catalog=ogrenci;Uid=bsaka;Pwd=123");

            // SqlCommand nesne_adı=new SqlCommand(sorgu,bağlantı);
            // SqlCommand komut=new SqlCommand("insert/update/delete/select...",baglanti);

            // SqlCommand komut=new SqlCommand("insert into tblOrnek(oAs,oTel,OYas,oMem) values ('"+deg1+"','"+deg2+"',"+deg3+",'"+deg4+"')",baglanti);


            // komut.ExecuteNonQuery();

            // komut.ExecuteReader();

            // komut.ExecuteScaler();

            // baglanti.Open();
            // baglanti.Close();

            string oas, otel, omem;
            int oyas;
            oas = textBox1.Text;
            otel = textBox2.Text;
            oyas = Convert.ToInt32(textBox3.Text);
            omem = textBox4.Text;
            SqlConnection baglanti = new SqlConnection("Data Source=.\\Sqlexpress;Initial Catalog=ogrenci;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into tblOrnek(oAs,oTel,OYas,oMem) values ('" + oas + "','" + otel + "'," + oyas + ",'" + omem + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            SqlConnection baglanti = new SqlConnection("Data Source=.\\Sqlexpress;Initial Catalog=ogrenci;Integrated Security=True");
            if (baglanti.State==ConnectionState.Closed)
                baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from tblornek",baglanti);           
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0]);
                listBox2.Items.Add(dr[1]);
                listBox3.Items.Add(dr[2]);
                listBox4.Items.Add(dr[3]);
            }
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.\\Sqlexpress;Initial Catalog=ogrenci;Integrated Security=True");
            
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string istogr = textBox5.Text;
            SqlCommand komut = new SqlCommand("delete from tblornek where oTel='"+istogr+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            textBox5.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string oas, otel, omem;
            int oyas;
            oas = textBox1.Text;
            otel = textBox2.Text;
            oyas = Convert.ToInt32(textBox3.Text);
            omem = textBox4.Text;
            SqlConnection baglanti = new SqlConnection("Data Source=.\\Sqlexpress;Initial Catalog=ogrenci;Integrated Security=True");

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string istogr = textBox5.Text;
            SqlCommand komut = new SqlCommand("update tblornek set oAs='"+oas+ "',oTel='"+otel+ "',oYas='"+oyas+ "',oMem='"+omem+"' where oTel='" + istogr + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
