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

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=dersVTYS;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  SqlConnection nesne_adı = new SqlConnection("Data Source=sunucu_adı veya ip si;Initial Catalog=veritabanı_adı;Integrated Security=True");
            // Server=;Database=
            // SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=dersVTYS;Integrated Security=True");
            //  conn.Open();
            //SqlCommand nesne_adı = new SqlCommand(sorgu,bağlantı);
            //  SqlCommand cmd = new SqlCommand("select * from tblDersler",conn);            
            //  SqlDataReader dr= cmd.ExecuteReader();
            //  conn.Close();
            
            int dkodu, dkredi;
            string dadi;
            dkodu = Convert.ToInt32(textBox1.Text);
            dadi = textBox2.Text;
            dkredi = Convert.ToInt32(textBox3.Text);
            SqlCommand cmd = new SqlCommand("insert into tblDersler(dersKodu,dersIsmi,dersKredi) values ("+dkodu+",'"+dadi+"',"+dkredi+")",conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            SqlCommand cmd = new SqlCommand("select * from tblDersler", conn);
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0]);
                listBox2.Items.Add(dr[1]);
                listBox3.Items.Add(dr[2]);
            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            int istdkodu = Convert.ToInt32(textBox4.Text);
            SqlCommand cmd = new SqlCommand("delete from tblDersler where dersKodu="+istdkodu+"",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int dkodu, dkredi;
            string dadi;
            dkodu = Convert.ToInt32(textBox1.Text);
            dadi = textBox2.Text;
            dkredi = Convert.ToInt32(textBox3.Text);
            int istdkodu = Convert.ToInt32(textBox4.Text);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand("update tblDersler set dersKodu="+dkodu+ ",dersIsmi='" + dadi+"',dersKredi="+dkredi+" where dersKodu="+ istdkodu + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // sql aşılama (sql injection)
            SqlCommand cmd = new SqlCommand("insert into tblDersler (dersKodu,dersIsmi,dersKredi) values (@dk,@di,@dkr)", conn);
            cmd.Parameters.AddWithValue("@dk",textBox1.Text);
            cmd.Parameters.AddWithValue("@di", textBox2.Text);
            cmd.Parameters.AddWithValue("@dkr", textBox3.Text);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
