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
    public partial class KaradenizLaterit : Form
    {
        public KaradenizLaterit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=EnIyiBakimEnIyiVerim;Integrated Security=True");
        int sayac = 0;
        private void enCokUretileniGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KaradenizLaterit", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lVEnCokU.Items.Add(oku["id"].ToString());
                lVEnCokU.Items.Add(oku["enCokUretilenler"].ToString());
                // lVEnCokU.Items[sayac].SubItems.Add(oku["id"].ToString());
                //lVEnCokU.Items[sayac].SubItems.Add(oku["enCokUretilenler"].ToString());
                sayac++;
            }
            baglanti.Close();
        }
        private void genelOzellikleriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KaradenizLaterit", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lVGenelOzellikleri.Items.Add(oku["id"].ToString());
                lVGenelOzellikleri.Items.Add(oku["ToprakTipininGenelOz"].ToString());
                //lVGenelOzellikleri.Items[sayac].SubItems.Add(oku["id"].ToString());
                //lVGenelOzellikleri.Items[sayac].SubItems.Add(oku["ToprakTipininGenelOz"].ToString());
                sayac++;
            }
            baglanti.Close();
        }
        private void uretilenDigerUrunleriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KaradenizLaterit", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lVGeneldeUretilenler.Items.Add(oku["id"].ToString());
                lVGeneldeUretilenler.Items.Add(oku["GenelOlarakÜretilenler"].ToString());
                //lVGeneldeUretilenler.Items[sayac].SubItems.Add(oku["id"].ToString());
                //lVGeneldeUretilenler.Items[sayac].SubItems.Add(oku["GenelOlarakÜretilenler"].ToString());
                sayac++;
            }
            baglanti.Close();
        }
        private void btnEnCokUretilenler_Click(object sender, EventArgs e)
        {
            enCokUretileniGoster();
        }

        private void btnGenelOzellikler_Click(object sender, EventArgs e)
        {
            genelOzellikleriGoster();
        }

        private void btnGeneldeUretilenler_Click(object sender, EventArgs e)
        {
            uretilenDigerUrunleriGoster();
        }
    }
}
