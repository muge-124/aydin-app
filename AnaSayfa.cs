using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AydınDinlenmeTesisleri
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YeniMüşteriEkle fr=new YeniMüşteriEkle();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMüsteriBilgileri fr=new FrmMüsteriBilgileri();
            fr.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aydın Dinlenme Tesisleri Kayıt Uygulaması -2023 -Karabük");
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odalar fr=new Odalar();
            fr.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr=new FrmGelirGider();
            fr.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Stoklar fr=new Stoklar();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RadyoDinle fr=new RadyoDinle();
            fr.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Gazeteler fr=new Gazeteler();
            fr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SıfreGuncelle fr=new SıfreGuncelle();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Mesajlar fr=new Mesajlar();
            fr.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            PhoneBook fr=new PhoneBook();
            fr.Show();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Şehirler fr=new Şehirler();
            fr.Show();
        }
    }
}
