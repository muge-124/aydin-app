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
    public partial class YeniMüşteriEkle : Form
    {
        public YeniMüşteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-G90VHP5\\SQLEXPRESS;Initial Catalog=AydınDinlenmeTesisleri;Integrated Security=True;");
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnOda401_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "401";
            bağlanti.Open();
            SqlCommand komut=new SqlCommand("insert into Oda401(Adi,Soyadi)values('"+TxtAdi.Text+"','"+TxtSoyadi.Text+"')",bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
            
        }

        private void BtnOda402_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "402";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda402(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void BtnOda403_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "403";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda403(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void BtnOda404_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "404";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda404(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void BtnOda405_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "405";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda405(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void BtnOda406_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "406";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda406(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void BtnOda407_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "407";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda407(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void BtnOda408_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "408";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda408(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void BtnOda409_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "409";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda409(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("gri renkli odalar dolu");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mavi renkli odalar boş");
        }

        private void DtpÇıkışTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirişTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpÇıkışTarihi.Text);
            TimeSpan Sonuc = BuyukTarih - KucukTarih;
            label11.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label11.Text) * 50;
            TxtÜcret.Text = Ucret.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle(Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values ('" + TxtAdi.Text + "' , '" + TxtSoyadi.Text + "','" + comboBox1.Text + "','" + MskTxtTelefon.Text + "','" + TxtMail.Text + "',+'" + TxtKimlikNo.Text + "','" + TxtOdaNumarası.Text + "','" + TxtÜcret.Text + "','" + DtpGirişTarihi.Value.ToString("yyyy-MM-dd") + "','" + DtpÇıkışTarihi.Value.ToString("yyyy-MM-dd") + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
            MessageBox.Show("müşteri kaydı yapıldı");



        }

        private void YeniMüşteriEkle_Load(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda406", bağlanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda406.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (BtnOda406.Text != "406")
            {
                BtnOda406.BackColor = Color.Red;
                BtnOda406.Enabled = false;
            }

            bağlanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda409", bağlanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda409.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (BtnOda409.Text != "409")
            {
                BtnOda409.BackColor = Color.Red;
                BtnOda409.Enabled = false;
            }
            bağlanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda401", bağlanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda401.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (BtnOda401.Text != "401")
            {
                BtnOda401.BackColor = Color.Red;
                BtnOda401.Enabled = false;
            }
            bağlanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda402", bağlanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda402.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (BtnOda402.Text != "402")
            {
                BtnOda402.BackColor = Color.Red;
                BtnOda402.Enabled = false;
            }
            bağlanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda403", bağlanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda403.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (BtnOda403.Text != "403")
            {
                BtnOda403.BackColor = Color.Red;
                BtnOda403.Enabled = false;
            }
            bağlanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda404", bağlanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda404.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (BtnOda404.Text != "404")
            {
                BtnOda404.BackColor = Color.Red;
                BtnOda404.Enabled = false;
            }
            bağlanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda405", bağlanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda405.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (BtnOda405.Text != "405")
            {
                BtnOda405.BackColor = Color.Red;
                BtnOda405.Enabled = false;
            }

        }
    }
}
    //Data Source=DESKTOP-G90VHP5\SQLEXPRESS;Initial Catalog=AydınDinlenmeTesisleri;Integrated Security=True;Trust Server Certificate=True

