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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
       SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-G90VHP5\\SQLEXPRESS;Initial Catalog=AydınDinlenmeTesisleri;Integrated Security=True;");

       
        private void Odalar_Load(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut1= new SqlCommand("select * from Oda406", bağlanti);
            SqlDataReader oku1=komut1.ExecuteReader();

            while(oku1.Read())
            {
                BtnOda406.Text = oku1["Adi"].ToString() +" "+oku1["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (BtnOda406.Text != "406")
            {
                BtnOda406.BackColor = Color.Red;
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
            }

        }
 
        }
}
