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
    public partial class Stoklar : Form
    {
        public Stoklar()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-G90VHP5\\SQLEXPRESS;Initial Catalog=AydınDinlenmeTesisleri;Integrated Security=True;");
        private void veriler()
        {
            listView1.Items.Clear();
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", bağlanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);

            }
            bağlanti.Close();
        }
        private void veriler2()
        {
            listView2.Items.Clear();
            bağlanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Faturalar", bağlanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektirik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["İnternet"].ToString());
                listView2.Items.Add(ekle);

            }
            bağlanti.Close();
        }
        private void Stoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar(Gida,İcecek,Cerezler) values('" + TxtGidalar.Text + "','" + Txtİçecekler.Text + "','" + TxtAtıştırmalıklar.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
            veriler();
        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Faturalar(Elektirik,Su,İnternet) values('" + TxtElektirik.Text + "','" + TxtSu.Text + "','" + Txtİnternet.Text + "')", bağlanti);
            komut2.ExecuteNonQuery();
            bağlanti.Close();
            veriler2();
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar(Gida,İcecek,Cerezler) values('" + TxtGidalar.Text + "','" + Txtİçecekler.Text + "','" + TxtAtıştırmalıklar.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
            veriler();
        }
    }
}