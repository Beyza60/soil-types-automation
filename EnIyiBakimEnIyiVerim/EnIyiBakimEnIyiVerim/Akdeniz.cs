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
    public partial class Akdeniz : Form
    {
        public Akdeniz()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=EnIyiBakimEnIyiVerim;Integrated Security=True");
        private void VerileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from Akdeniz", baglanti);
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
        private void Akdeniz_Load(object sender, EventArgs e)
        {
            txtAkdeniz.Text = "Bölgede genelde yazları sıcak ve kurak, kışları ılık ve yağışlı geçen Akdeniz iklimi egemendir. " +
                "Ancak yüksekliğe bağlı olarak iklim özellikleri oldukça önemli farklılaşmalar gösterir." +
                " Dağların denize bakan yamaçlarında ve arkalarında çukur alanlar ise karasal etkilerin arttığı bir iklim tipine rastlanır.";
        }

        private void btnToprakBilgisi_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            string tip =txtToprakTipi.Text.ToString();
            if (tip=="Terra Rossa")
            {
                TerraRossa tr = new TerraRossa();
                tr.Show();
            }
            else if (tip=="Kestane renkli topraklar")
            {
                KestaneRenkli kr = new KestaneRenkli();
                kr.Show();
            }
            else
            {
                MessageBox.Show("yanlış yazdınız lütfen yazınızı kontrol ediniz!!!");
            }
        }
    }
}
