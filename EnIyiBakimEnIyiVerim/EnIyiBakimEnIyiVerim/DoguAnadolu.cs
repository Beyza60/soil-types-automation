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
    public partial class DoguAnadolu : Form
    {
        public DoguAnadolu()
        {
            InitializeComponent();
        }
// Yüzölçümü bakımından % 21 ile en büyük bölgedir.
//En az nüfusa sahip olan ve nüfus yoğunluğu en az olan bölgedir.
//Ortalama yükseltisi en fazla olan bölgedir.
//En fazla yağışı yaz mevsiminde alan bölgedir.
//Orman bakımından % 7 ile 6. sıradadır.
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=EnIyiBakimEnIyiVerim;Integrated Security=True");
        private void VerileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from DoguAnadolu", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            int sayac = 0;
            while (oku.Read())
            {
                lVToprakTipleri.Items.Add(oku["id"].ToString());
                lVToprakTipleri.Items.Add(oku["ToprakTipi"].ToString());
                lVToprakTipleri.Items.Add(oku["KapsadigiBolge"].ToString());
                lVToprakTipleri.Items.Add(oku["ToprakBilgisi"].ToString());
                //
                lVToprakTipleri.Items[sayac].SubItems.Add(oku["id"].ToString());
                lVToprakTipleri.Items[sayac].SubItems.Add(oku["ToprakTipi"].ToString());
                lVToprakTipleri.Items[sayac].SubItems.Add(oku["KapsadigiBolge"].ToString());
                lVToprakTipleri.Items[sayac].SubItems.Add(oku["ToprakBilgisi"].ToString());
                sayac++;
            }
            baglanti.Close();
        }
        private void DoguAnadolu_Load(object sender, EventArgs e)
        {
            txtDoguAnadolu.Text = "Bölgenin kuzey kesimlerinde daha çok Kara topraklar yer almaktadır." +
                " Bunlar arasında dağınık şekilde ve bölgenin farklı kesimlerinde Kırmızı topraklara rastlanır." +
                " Bölgenin yaygın bir toprak grubu ise yüksek dağlar arasındaki havzalarda yer alan Alüvyal topraklardır." +
                " Bölgede karasal iklim hakimdir.";
        }

        private void btnToprakBilgisi_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            string tip = txtToprakTipi.Text.ToString();
            if (tip=="Kara Toprak")
            {
                KaraToprak kt = new KaraToprak();
                kt.Show();
            }
            else if (tip=="Alüvyal Toprak")
            {
                AluvyalToprak at = new AluvyalToprak();
                at.Show();
            }
        }
    }
}
