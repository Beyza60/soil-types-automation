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
    public partial class IcAnadolu : Form
    {
        public IcAnadolu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=EnIyiBakimEnIyiVerim;Integrated Security=True");
        private void VerileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from IcAnadolu", baglanti);
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
            }baglanti.Close();
        }
        private void btnToprakTipleri_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            string tip = txtToprakTipi.Text.ToString();
            if (tip=="Tuzsuz topraklar")
            {
                Tuzsuz ts = new Tuzsuz();
                ts.Show();
            }
            else if (tip=="Hafif alkali")
            {
                HafifAlkali ha = new HafifAlkali();
                ha.Show();
            }
            else
            {
                MessageBox.Show("Yazınızı kontrol ediniz!!!");
            }
        }

        private void IcAnadolu_Load(object sender, EventArgs e)
        {
            txtIcAnadolu.Text = "İç Anadolu Bölgesi'nde yazları sıcak ve kurak, kışları ise soğuk ve kar yağışlı geçtiği görülür. " +
                "Çünkü bu bölgede karasal iklim hakimdir. İç Anadolu en kurak bölgelerden olup, en fazla yağış ise ilkbahar aylarında görülür." +
                " En az yağış alan yeri ise Tuz Gölü çevresidir ve yıllık yağış miktarı sadece 320 mm'dir.";
        }
    }
}
