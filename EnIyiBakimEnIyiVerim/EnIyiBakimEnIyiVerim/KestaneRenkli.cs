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
    public partial class KestaneRenkli : Form
    {
        public KestaneRenkli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=EnIyiBakimEnIyiVerim;Integrated Security=True");
        int sayac =0;
        private void enCokUretileniGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KestaneRenkliTopraklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lVPodzolEnCokU.Items.Add(oku["id"].ToString());
                lVPodzolEnCokU.Items.Add(oku["enCokUretilenler"].ToString());
                // lVPodzolEnCokU.Items[sayac].SubItems.Add(oku["id"].ToString());
                //lVPodzolEnCokU.Items[sayac].SubItems.Add(oku["enCokUretilenler"].ToString());
                sayac++;
            }
            baglanti.Close();
        }
        private void genelOzellikleriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KestaneRenkliTopraklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lVGenelOzellikler.Items.Add(oku["id"].ToString());
                lVGenelOzellikler.Items.Add(oku["ToprakTipininGenelOz"].ToString());
                //lVGenelOzellikler.Items[sayac].SubItems.Add(oku["id"].ToString());
                //lVGenelOzellikler.Items[sayac].SubItems.Add(oku["ToprakTipininGenelOz"].ToString());
                sayac++;
            }
            baglanti.Close();
        }
        private void uretilenDigerUrunleriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KestaneRenkliTopraklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lVGeneldeU.Items.Add(oku["id"].ToString());
                lVGeneldeU.Items.Add(oku["GenelOlarakÜretilenler"].ToString());
                //  lVGeneldeU.Items[sayac].SubItems.Add(oku["id"].ToString());
                // lVGeneldeU.Items[sayac].SubItems.Add(oku["GenelOlarakÜretilenler"].ToString());
                sayac++;
            }
            baglanti.Close();
        }
        private void btnEnCokU_Click(object sender, EventArgs e)
        {
            enCokUretileniGoster();
        }

        private void btnGenelOzellikler_Click(object sender, EventArgs e)
        {
            genelOzellikleriGoster();
        }

        private void btnUretilenDigerU_Click(object sender, EventArgs e)
        {
            uretilenDigerUrunleriGoster();
        }
    }
}
