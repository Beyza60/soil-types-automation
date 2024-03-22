using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnIyiBakimEnIyiVerim
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=EnIyiBakimEnIyiVerim;Integrated Security=True");
        private void AnaEkran_Load(object sender, EventArgs e)
        {
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kullanici(Adi,Sifre)values('" + txtYeniKullanici.Text + "','" + txtYeniSifre.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select*from Kullanici where Adi=@Kullanici Adi AND Sifre=@Sifre";
                SqlParameter prm1 = new SqlParameter("Kullanici Adi", txtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", txtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Bolgeler bg = new Bolgeler();
                    bg.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş yaptınız bilgilerinizi kontrol ediniz.");
            }
        }

        private void btnUyeOlmadan_Click(object sender, EventArgs e)
        {
            Bolgeler bg = new Bolgeler();
            bg.Show();
            this.Hide();
        }
    }
}
