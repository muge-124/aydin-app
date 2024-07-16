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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-G90VHP5\\SQLEXPRESS;Initial Catalog=AydınDinlenmeTesisleri;Integrated Security=True;");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            LblPersonalMaas.Text = (personel * 1500).ToString();
            int sonuc;
            sonuc = Convert.ToInt32(LblKasaToplam.Text)-(Convert.ToInt32(LblPersonalMaas.Text)+Convert.ToInt32(LblAlinanUrunler1.Text)+ Convert.ToInt32(LblAlinanUrunler2.Text)+ Convert.ToInt32(LblAlinanUrunler3.Text)+ Convert.ToInt32(LblFaturalar1.Text)+ Convert.ToInt32(LblFaturalar2.Text)+ Convert.ToInt32(LblFaturalar3.Text));
            LblSonuc.Text = sonuc.ToString();


        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutar
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle", bağlanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();

            }
            bağlanti.Close();

            
           

            //gidalar
            bağlanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Gida) as toplam1 from Stoklar", bağlanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblAlinanUrunler1.Text = oku2["toplam1"].ToString();

            }
            bağlanti.Close();

            //ıcecekler
            bağlanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(İcecek) as toplam2 from Stoklar", bağlanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblAlinanUrunler2.Text = oku3["toplam2"].ToString();

            }
            bağlanti.Close();
            //gidalar
            bağlanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Cerezler) as toplam4 from Stoklar", bağlanti);
            SqlDataReader oku4= komut4.ExecuteReader();
            while (oku4.Read())
            {
                LblAlinanUrunler3.Text = oku4["toplam4"].ToString();

            }
            bağlanti.Close();
            //elektirik
            bağlanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Elektirik) as toplam5 from Faturalar", bağlanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                LblFaturalar1.Text = oku5["toplam5"].ToString();

            }
            bağlanti.Close();
            bağlanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Su) as toplam6 from Faturalar", bağlanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
               LblFaturalar2.Text = oku6["toplam6"].ToString();

            }
            bağlanti.Close();
            bağlanti.Open();
            SqlCommand komut7 = new SqlCommand("select sum(İnternet) as toplam7 from Faturalar", bağlanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                LblFaturalar3.Text = oku7["toplam7"].ToString();

            }
            bağlanti.Close();

          
           

        }
    }
}
