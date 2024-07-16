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
    public partial class FrmMüsteriBilgileri : Form
    {
        public FrmMüsteriBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-G90VHP5\\SQLEXPRESS;Initial Catalog=AydınDinlenmeTesisleri;Integrated Security=True;");

        private void verilergoster()
        {
            listView1.Items.Clear();
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", bağlanti);
            SqlDataReader Oku=komut.ExecuteReader();

            while (Oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = Oku["Musteriid"].ToString();
                ekle.SubItems.Add(Oku["Adi"].ToString());
                ekle.SubItems.Add(Oku["Soyadi"].ToString());
                ekle.SubItems.Add(Oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(Oku["Telefon"].ToString());
                ekle.SubItems.Add(Oku["Mail"].ToString());
                ekle.SubItems.Add(Oku["TC"].ToString());
                ekle.SubItems.Add(Oku["OdaNo"].ToString());
                ekle.SubItems.Add(Oku["Ucret"].ToString());
                ekle.SubItems.Add(Oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(Oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            bağlanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        int id = 0;
        //verileri textbox taşıdık
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text= listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text= listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text= listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text= listView1.SelectedItems[0].SubItems[5].Text;
            TxtKimlikNo.Text= listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNumarası.Text= listView1.SelectedItems[0].SubItems[7].Text;
            TxtÜcret.Text= listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirişTarihi.Text= listView1.SelectedItems[0].SubItems[9].Text;
            DtpÇıkışTarihi.Text= listView1.SelectedItems[0].SubItems[10].Text;


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
            verilergoster();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = " ";
            MskTxtTelefon.Clear();
            TxtMail.Clear();
            TxtKimlikNo.Clear();
            TxtOdaNumarası.Clear();
            TxtÜcret.Clear();
            

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + MskTxtTelefon.Text + "',Mail='" + TxtMail.Text + "',TC='" + TxtKimlikNo.Text + "',OdaNo='" + TxtOdaNumarası.Text + "',Ucret='" + TxtÜcret.Text + "',GirisTarihi='" + DtpGirişTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + DtpÇıkışTarihi.Value.ToString("yyyy-MM-dd") + "' where Musteriid=" + id + "", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
            verilergoster();
        }

        private void BtnArama_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%"+textBox1.Text+"%'", bağlanti);
            SqlDataReader Oku = komut.ExecuteReader();

            while (Oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = Oku["Musteriid"].ToString();
                ekle.SubItems.Add(Oku["Adi"].ToString());
                ekle.SubItems.Add(Oku["Soyadi"].ToString());
                ekle.SubItems.Add(Oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(Oku["Telefon"].ToString());
                ekle.SubItems.Add(Oku["Mail"].ToString());
                ekle.SubItems.Add(Oku["TC"].ToString());
                ekle.SubItems.Add(Oku["OdaNo"].ToString());
                ekle.SubItems.Add(Oku["Ucret"].ToString());
                ekle.SubItems.Add(Oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(Oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            bağlanti.Close();
        }

        private void FrmMüsteriBilgileri_Load(object sender, EventArgs e)
        {

        }
    }
}
