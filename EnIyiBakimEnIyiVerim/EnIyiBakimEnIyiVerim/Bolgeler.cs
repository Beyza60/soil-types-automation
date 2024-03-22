using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnIyiBakimEnIyiVerim
{
    public partial class Bolgeler : Form
    {
        public Bolgeler()
        {
            InitializeComponent();
        }

        private void btnMarmara_Click(object sender, EventArgs e)
        {
            Marmara mr = new Marmara();
            mr.Show();
         
        }

        private void btnAkdeniz_Click(object sender, EventArgs e)
        {
            Akdeniz az = new Akdeniz();
            az.Show();
        }

        private void btnEge_Click(object sender, EventArgs e)
        {
            Ege ege = new Ege();
            ege.Show();
        }

        private void btnKaradeniz_Click(object sender, EventArgs e)
        {
            Karadeniz kz = new Karadeniz();
            kz.Show();
        }

        private void btnDoguAnadolu_Click(object sender, EventArgs e)
        {
            DoguAnadolu da = new DoguAnadolu();
            da.Show();
        }

        private void btnIcAnadolu_Click(object sender, EventArgs e)
        {
            IcAnadolu ia = new IcAnadolu();
            ia.Show();
        }

        private void btnGuneyDoguAnadolu_Click(object sender, EventArgs e)
        {
            GuneyDoguAnadolu ga = new GuneyDoguAnadolu();
            ga.Show(); 
        }

        private void Bolgeler_Load(object sender, EventArgs e)
        {

        }
    }
}
