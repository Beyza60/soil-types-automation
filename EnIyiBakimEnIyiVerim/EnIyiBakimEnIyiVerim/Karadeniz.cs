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
    public partial class Karadeniz : Form
    {
        public Karadeniz()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=EnIyiBakimEnIyiVerim;Integrated Security=True");
        private void Karadeniz_Load(object sender, EventArgs e)
        {
            txtKaradeniz.Text = "Karadeniz'in doğusunda bitki çok olmasına rağmen humusun az olmasının sebebi toprağın aşırı yıkanmasıdır." +
                " Humus,alüvyon,Lös,moren gibi taşınmış topraklarda olmaz." +
                "Buna rağmen taşınmış toprakların verimli olmasının sebebi mineral bakımından zengin olmasıdır. " +
                "Bulundukları bölgelerin iklimlerini tam olarak yansıtmazlar.";
        }
        private void verileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Karadeniz", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            int sayac = 0;
            while (oku.Read())
            {
                lVToprakTipleri.Items.Add(oku["id"].ToString());
                lVToprakTipleri.Items.Add(oku["ToprakTipi"].ToString());
                lVToprakTipleri.Items.Add(oku["KapsadigiBolge"].ToString());
                lVToprakTipleri.Items.Add(oku["ToprakBilgisi"].ToString());
                //ekleme yapılmak istenirse!!
                lVToprakTipleri.Items[sayac].SubItems.Add(oku["id"].ToString());
                lVToprakTipleri.Items[sayac].SubItems.Add(oku["ToprakTipi"].ToString());
                lVToprakTipleri.Items[sayac].SubItems.Add(oku["KapsadigiBolge"].ToString());
                lVToprakTipleri.Items[sayac].SubItems.Add(oku["ToprakBilgisi"].ToString());
                sayac++;
            }baglanti.Close();
        }

        private void btnToprakTipleri_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            string girilenTip = txtToprakTipi.Text.ToString();
            if (girilenTip == "Laterit")
            {
                KaradenizLaterit kl = new KaradenizLaterit();
                kl.Show();
            }
            else if (girilenTip == "Podzol")
            {
                KaradenizPodzol kp = new KaradenizPodzol();
                kp.Show();
            }
            else
                MessageBox.Show("eksik veya hatalı yazdınız, yazınızı lütfen kontrol ediniz.");
        }
    }
}
