using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using AydınDinlenmeTesisleri;


namespace AydınDinlenmeTesisleri
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-G90VHP5\\SQLEXPRESS;Initial Catalog=AydınDinlenmeTesisleri;Integrated Security=True;");
        private void BtnGirişYap_Click(object sender, EventArgs e)
        {
            try
            {
                bağlanti.Open();
                string sql = "select * from AdminGiris where Kullanici=@KullaniciAdi AND Sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("Kullaniciadi", TxtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, bağlanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt=new DataTable();
                SqlDataAdapter da=new SqlDataAdapter(komut);

                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    AnaSayfa fr=new AnaSayfa();
                    fr.Show();
                    this.Hide();
                }


            }
            catch (Exception)
            {


                MessageBox.Show("hatalı giriş");
            }
           
        
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
/* if (TxtKullaniciAdi.Text == "admin" && TxtSifre.Text == "12345")
{
    AnaSayfa fr = new AnaSayfa();
    fr.Show();
    this.Hide();
}
            else
    MessageBox.Show("kullanıcı adı veya şifre hatalı");
*/

