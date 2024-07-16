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
using System.Data.Sql;

namespace AydınDinlenmeTesisleri
{
    public partial class PhoneBook : Form
    {
        public PhoneBook()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-G90VHP5\\SQLEXPRESS;Initial Catalog=AydınDinlenmeTesisleri;Integrated Security=True;");
        private void PhoneBook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
           bağlanti.Open();
           SqlDataAdapter sqlDa=new SqlDataAdapter("SELECT * FROM PhoneBook",bağlanti);
            DataTable dtb1=new DataTable();
            sqlDa.Fill(dtb1);

            dataGridView1.DataSource = dtb1;
             bağlanti.Close();

        }

        
    }
}
