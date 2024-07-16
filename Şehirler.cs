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

namespace AydınDinlenmeTesisleri
{
    public partial class Şehirler : Form
    {
        public Şehirler()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-G90VHP5\\SQLEXPRESS;Initial Catalog=AydınDinlenmeTesisleri;Integrated Security=True;");
        private void chart1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "?";
            chart1.Series[0].YValueMembers = "?";



            chart1.Series[1].XValueMember = "İstanbul";
            chart1.Series[1].YValueMembers = "İstanbul";

            chart1.Series[2].XValueMember = "Karabük";
            chart1.Series[2].YValueMembers = "Karabük";

            chart1.Series[3].XValueMember = "Bursa";
            chart1.Series[3].YValueMembers = "Bursa";


            chart1.Series[4].XValueMember = "Ankara";
            chart1.Series[4].YValueMembers = "Ankara";

            chart1.DataSource = aydınDinlenmeTesisleriDataSet1.Sehirler5;
            chart1.DataBind();

            

           




        }


        private void Şehirler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aydınDinlenmeTesisleriDataSet1.Sehirler5' table. You can move, or remove it, as needed.
            this.sehirler5TableAdapter.Fill(this.aydınDinlenmeTesisleriDataSet1.Sehirler5);
            

        }
    }
    }

