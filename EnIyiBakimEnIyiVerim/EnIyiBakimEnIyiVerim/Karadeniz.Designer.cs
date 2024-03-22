
namespace EnIyiBakimEnIyiVerim
{
    partial class Karadeniz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnArama = new System.Windows.Forms.Button();
            this.btnToprakTipleri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKaradeniz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToprakTipi = new System.Windows.Forms.TextBox();
            this.lVToprakTipleri = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnArama
            // 
            this.btnArama.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnArama.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnArama.Location = new System.Drawing.Point(587, 325);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(167, 43);
            this.btnArama.TabIndex = 9;
            this.btnArama.Text = "ARA";
            this.btnArama.UseVisualStyleBackColor = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnToprakTipleri
            // 
            this.btnToprakTipleri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnToprakTipleri.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToprakTipleri.Location = new System.Drawing.Point(68, 286);
            this.btnToprakTipleri.Name = "btnToprakTipleri";
            this.btnToprakTipleri.Size = new System.Drawing.Size(167, 43);
            this.btnToprakTipleri.TabIndex = 8;
            this.btnToprakTipleri.Text = "Toprak Çeşitleri";
            this.btnToprakTipleri.UseVisualStyleBackColor = false;
            this.btnToprakTipleri.Click += new System.EventHandler(this.btnToprakTipleri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(262, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Karadeniz Bölgesi";
            // 
            // txtKaradeniz
            // 
            this.txtKaradeniz.BackColor = System.Drawing.SystemColors.Info;
            this.txtKaradeniz.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKaradeniz.Location = new System.Drawing.Point(12, 76);
            this.txtKaradeniz.Multiline = true;
            this.txtKaradeniz.Name = "txtKaradeniz";
            this.txtKaradeniz.Size = new System.Drawing.Size(689, 124);
            this.txtKaradeniz.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(539, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Araığınız Toprak Tipini giriniz";
            // 
            // txtToprakTipi
            // 
            this.txtToprakTipi.BackColor = System.Drawing.SystemColors.Info;
            this.txtToprakTipi.Location = new System.Drawing.Point(565, 241);
            this.txtToprakTipi.Multiline = true;
            this.txtToprakTipi.Name = "txtToprakTipi";
            this.txtToprakTipi.Size = new System.Drawing.Size(204, 56);
            this.txtToprakTipi.TabIndex = 14;
            // 
            // lVToprakTipleri
            // 
            this.lVToprakTipleri.BackColor = System.Drawing.SystemColors.Info;
            this.lVToprakTipleri.HideSelection = false;
            this.lVToprakTipleri.Location = new System.Drawing.Point(-1, 335);
            this.lVToprakTipleri.Name = "lVToprakTipleri";
            this.lVToprakTipleri.Size = new System.Drawing.Size(582, 127);
            this.lVToprakTipleri.TabIndex = 15;
            this.lVToprakTipleri.UseCompatibleStateImageBehavior = false;
            this.lVToprakTipleri.View = System.Windows.Forms.View.SmallIcon;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Chocolate;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(651, 397);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 91);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Büyük küçük harfe duyarlıdır. Yazarken dikkatt ediniz!!";
            // 
            // Karadeniz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnIyiBakimEnIyiVerim.Properties.Resources.download2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lVToprakTipleri);
            this.Controls.Add(this.txtToprakTipi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKaradeniz);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.btnToprakTipleri);
            this.Controls.Add(this.label1);
            this.Name = "Karadeniz";
            this.Text = "Karadeniz";
            this.Load += new System.EventHandler(this.Karadeniz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnToprakTipleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKaradeniz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToprakTipi;
        private System.Windows.Forms.ListView lVToprakTipleri;
        private System.Windows.Forms.TextBox textBox1;
    }
}