
namespace EnIyiBakimEnIyiVerim
{
    partial class AnaEkran
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.btnUyeOlmadan = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYeniKullanici = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBaslik
            // 
            this.txtBaslik.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBaslik.Location = new System.Drawing.Point(130, 76);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(480, 48);
            this.txtBaslik.TabIndex = 0;
            this.txtBaslik.Text = "~EN İYİ BAKIM EN İYİ VERİM~";
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUyeOl.Location = new System.Drawing.Point(188, 174);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(171, 52);
            this.btnUyeOl.TabIndex = 1;
            this.btnUyeOl.Text = "üye girişi/üye ol";
            this.btnUyeOl.UseVisualStyleBackColor = false;
            // 
            // btnUyeOlmadan
            // 
            this.btnUyeOlmadan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUyeOlmadan.Location = new System.Drawing.Point(635, 237);
            this.btnUyeOlmadan.Name = "btnUyeOlmadan";
            this.btnUyeOlmadan.Size = new System.Drawing.Size(94, 73);
            this.btnUyeOlmadan.TabIndex = 2;
            this.btnUyeOlmadan.Text = "üye olmadan devam et";
            this.btnUyeOlmadan.UseVisualStyleBackColor = false;
            this.btnUyeOlmadan.Click += new System.EventHandler(this.btnUyeOlmadan_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_giris.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_giris.Location = new System.Drawing.Point(130, 337);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(94, 29);
            this.btn_giris.TabIndex = 3;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı: ";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(130, 241);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(125, 27);
            this.txtKullaniciAdi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre: ";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(130, 283);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(125, 27);
            this.txtSifre.TabIndex = 7;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(403, 283);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(125, 27);
            this.txtYeniSifre.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Yeni Şifre: ";
            // 
            // txtYeniKullanici
            // 
            this.txtYeniKullanici.Location = new System.Drawing.Point(403, 241);
            this.txtYeniKullanici.Name = "txtYeniKullanici";
            this.txtYeniKullanici.Size = new System.Drawing.Size(125, 27);
            this.txtYeniKullanici.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yeni Kullanıcı:";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_kaydet.Location = new System.Drawing.Point(403, 333);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(94, 29);
            this.btn_kaydet.TabIndex = 8;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYeniKullanici);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.btnUyeOlmadan);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.txtBaslik);
            this.Name = "AnaEkran";
            this.Text = "AnaEkran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.Button btnUyeOlmadan;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYeniKullanici;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_kaydet;
    }
}

