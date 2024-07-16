using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AydınDinlenmeTesisleri
{
    public partial class Mesajlar : Form
    {
        public Mesajlar()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-G90VHP5\\SQLEXPRESS;Initial Catalog=AydınDinlenmeTesisleri;Integrated Security=True;");
        private void verilergoster()
        {
            listView1.Items.Clear();
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("select * from Mesajlar", bağlanti);
            SqlDataReader Oku = komut.ExecuteReader();

            while (Oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = Oku["Mesajid"].ToString();
                ekle.SubItems.Add(Oku["Adsoyad"].ToString());
                ekle.SubItems.Add(Oku["Mesaj"].ToString());
               
                listView1.Items.Add(ekle);

            }
            bağlanti.Close();
        }
        private void Mesajlar_Load(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar(Adsoyad,Mesaj)values('" + textBox1.Text + "','" + richTextBox1.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
            verilergoster();
            
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;


        }
    }
}
