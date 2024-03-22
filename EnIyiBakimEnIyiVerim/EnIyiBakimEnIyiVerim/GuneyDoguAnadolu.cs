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
    public partial class GuneyDoguAnadolu : Form
    {
        public GuneyDoguAnadolu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=EnIyiBakimEnIyiVerim;Integrated Security=True");
        private void GuneyDoguAnadolu_Load(object sender, EventArgs e)
        {
            txtGuneydoguA.Text = "Güneydoğu Anadolu Bölgesi topraklarının çoğunu *kırmızı kahverengi topraklar* ve" +
                " *kahverengi toprak* grupları oluşturmaktadır. Yaz aylarında kurak geçen havalar, kışları yağışlı ve ılıktır." +
                " Akdeniz iklimi ile karşılaştırıldığında kışlar daha soğuk, yazlar ise daha sıcak geçmektedir.";
        }
        private void VerileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from GuneydoguAnadolu", baglanti);
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

        private void btnToprakBilgisi_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            string tip = txtToprakTipi.Text.ToString();
            if (tip=="Kahverengi bozkır")
            {
                KahverengiBozkir kb = new KahverengiBozkir();
                kb.Show();
            }
            else if (tip=="Kestane renkli bozkır")
            {
                KestaneRenkli kr = new KestaneRenkli();
                kr.Show();
            }
            else
            {
                MessageBox.Show("yazınızı kontrol ediniz, hatalı yazdınız!!");
            }
        }
    }
}
