using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnIyiBakimEnIyiVerim
{
    public partial class KaradenizPodzol : Form
    {
        public KaradenizPodzol()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=EnIyiBakimEnIyiVerim;Integrated Security=True");
       
        int sayac = 0;
        private void enCokUretileniGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KaradenizPodzol", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lVPodzolEnCokU.Items.Add(oku["id"].ToString());
                lVPodzolEnCokU.Items.Add(oku["enCokUretilen"].ToString());
               // lVPodzolEnCokU.Items[sayac].SubItems.Add(oku["id"].ToString());
                //lVPodzolEnCokU.Items[sayac].SubItems.Add(oku["enCokUretilen"].ToString());
                sayac++;
            }baglanti.Close();
        }
        private void genelOzellikleriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KaradenizPodzol", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lVGenelOzellikler.Items.Add(oku["id"].ToString());
                lVGenelOzellikler.Items.Add(oku["genelOzellikleri"].ToString());
                //lVGenelOzellikler.Items[sayac].SubItems.Add(oku["id"].ToString());
                //lVGenelOzellikler.Items[sayac].SubItems.Add(oku["genelOzellikleri"].ToString());
                sayac++;
            }
            baglanti.Close();
        }
        private void uretilenDigerUrunleriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KaradenizPodzol", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lVGeneldeU.Items.Add(oku["id"].ToString());
                lVGeneldeU.Items.Add(oku["geneldeUretilenler"].ToString());
              //  lVGeneldeU.Items[sayac].SubItems.Add(oku["id"].ToString());
               // lVGeneldeU.Items[sayac].SubItems.Add(oku["geneldeUretilenler"].ToString());
                sayac++;
            }baglanti.Close();
        }
        private void btnPodzolEnCokU_Click(object sender, EventArgs e)
        {
            enCokUretileniGoster();
        }

        private void btnPodzolGenelOzellikler_Click(object sender, EventArgs e)
        {
            genelOzellikleriGoster();
        }

        private void btnPodzolUretilenDigerU_Click(object sender, EventArgs e)
        {
            uretilenDigerUrunleriGoster();
        }
    }
}
