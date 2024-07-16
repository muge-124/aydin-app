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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AydınDinlenmeTesisleri
{
    public partial class SıfreGuncelle : Form
    {
        public SıfreGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-G90VHP5\\SQLEXPRESS;Initial Catalog=AydınDinlenmeTesisleri;Integrated Security=True;");
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici='" +TxtKullaniciAdi.Text + "',Sifre='" + TxtSifre.Text + "'",bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
            
        }
    }
}
