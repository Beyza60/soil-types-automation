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
    public partial class Marmara : Form
    {
        public Marmara()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=EnIyiBakimEnIyiVerim;Integrated Security=True");
        private void Marmara_Load(object sender, EventArgs e)
        {
            txtMarmara.Text = "Marmara iklim özelliği; Karasal İklim," +
                " Karadeniz İklimi ve Akdeniz İklimleri arasında geçiş özelliği göstermesidir." +
                " Geçiş kuşağında yer alan Marmara Bölgesinde, Akdeniz İklimi'nin tesiri güneyden kuzeye doğru etkisini azaltır." +
                " Marmara İklim bölgesinde yaz, kış, sonbahar ve ilkbahar olmak üzere dört mevsim gözlenir.";
        }
        private void VerileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from Marmara",baglanti);
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
        private void btnArama_Click(object sender, EventArgs e)
        {
            string tip =txtArananToprakTipi.Text.ToString();
            if (tip == "Tuzsuz topraklar")
            {
                Tuzsuz ts = new Tuzsuz();
                ts.Show();
            }
            else if (tip == "Hafif alkali")
            {
                HafifAlkali ha = new HafifAlkali();
                ha.Show();
            }
            else
            {
                MessageBox.Show("Yazınızı kontrol ediniz!!!");
            }
        }

        private void btnToprakBilgisi_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }
    }
}
