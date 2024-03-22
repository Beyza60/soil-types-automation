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
    public partial class Ege : Form
    {
        public Ege()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=EnIyiBakimEnIyiVerim;Integrated Security=True");
        private void VerileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from Ege", baglanti);
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
        private void Ege_Load(object sender, EventArgs e)
        {
            txtEge.Text = " Asıl Ege Bölümü'nde Akdeniz iklimi etkilidir." +
                " Çöküntü graben ovalarının etkisiyle Akdeniz İklimi etkileri iç kısımlara kadar uzanır. " +
                "Bu bölümde kışlar ılık geçer, kar yağışı ve don olayı fazla görülmez. " +
                "Ege bölgesinin en büyük özellikleri arasında, yaz aylarında kurak olması bulunuyor." +
                " Kış aylarında çok yağış görülen bölgelerden biri değildir." +
                " Akdeniz iklimini yaşayan ve bitki örtüsü maki olan bölgelerden biridir. " +
                "Yaz aylarında oluşan yüksek sıcaklıklarla bilinen bir bölgedir.";
        }

        private void btnToprakBilgisi_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            String tip = txtToprakTipi.Text.ToString();
            if (tip=="Terra Rossa")
            {
                TerraRossa tr = new TerraRossa();
                tr.Show();
            }
            else
            {
                MessageBox.Show("yanlış yazdınız lütfen yazınızı kontrol ediniz!!!");
            }
        }
    }
}
