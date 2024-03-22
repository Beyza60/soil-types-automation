
namespace EnIyiBakimEnIyiVerim
{
    partial class Akdeniz
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lVToprakTipleri = new System.Windows.Forms.ListView();
            this.txtToprakTipi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAkdeniz = new System.Windows.Forms.TextBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnToprakBilgisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Chocolate;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(652, 401);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 91);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Büyük küçük harfe duyarlıdır. Yazarken dikkatt ediniz!!";
            // 
            // lVToprakTipleri
            // 
            this.lVToprakTipleri.BackColor = System.Drawing.SystemColors.Info;
            this.lVToprakTipleri.HideSelection = false;
            this.lVToprakTipleri.Location = new System.Drawing.Point(0, 365);
            this.lVToprakTipleri.Name = "lVToprakTipleri";
            this.lVToprakTipleri.Size = new System.Drawing.Size(582, 127);
            this.lVToprakTipleri.TabIndex = 23;
            this.lVToprakTipleri.UseCompatibleStateImageBehavior = false;
            this.lVToprakTipleri.View = System.Windows.Forms.View.SmallIcon;
            // 
            // txtToprakTipi
            // 
            this.txtToprakTipi.BackColor = System.Drawing.SystemColors.Info;
            this.txtToprakTipi.Location = new System.Drawing.Point(566, 245);
            this.txtToprakTipi.Multiline = true;
            this.txtToprakTipi.Name = "txtToprakTipi";
            this.txtToprakTipi.Size = new System.Drawing.Size(204, 56);
            this.txtToprakTipi.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(552, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Araığınız Toprak Tipini giriniz";
            // 
            // txtAkdeniz
            // 
            this.txtAkdeniz.BackColor = System.Drawing.SystemColors.Info;
            this.txtAkdeniz.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAkdeniz.Location = new System.Drawing.Point(13, 80);
            this.txtAkdeniz.Multiline = true;
            this.txtAkdeniz.Name = "txtAkdeniz";
            this.txtAkdeniz.Size = new System.Drawing.Size(689, 124);
            this.txtAkdeniz.TabIndex = 20;
            // 
            // btnArama
            // 
            this.btnArama.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnArama.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnArama.Location = new System.Drawing.Point(588, 329);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(167, 43);
            this.btnArama.TabIndex = 19;
            this.btnArama.Text = "ARA";
            this.btnArama.UseVisualStyleBackColor = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnToprakBilgisi
            // 
            this.btnToprakBilgisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnToprakBilgisi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToprakBilgisi.Location = new System.Drawing.Point(69, 316);
            this.btnToprakBilgisi.Name = "btnToprakBilgisi";
            this.btnToprakBilgisi.Size = new System.Drawing.Size(167, 43);
            this.btnToprakBilgisi.TabIndex = 18;
            this.btnToprakBilgisi.Text = "Toprak Bilgisi";
            this.btnToprakBilgisi.UseVisualStyleBackColor = false;
            this.btnToprakBilgisi.Click += new System.EventHandler(this.btnToprakBilgisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Akdeniz Bölgesi";
            // 
            // Akdeniz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnIyiBakimEnIyiVerim.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lVToprakTipleri);
            this.Controls.Add(this.txtToprakTipi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAkdeniz);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.btnToprakBilgisi);
            this.Controls.Add(this.label1);
            this.Name = "Akdeniz";
            this.Text = "Akdeniz";
            this.Load += new System.EventHandler(this.Akdeniz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView lVToprakTipleri;
        private System.Windows.Forms.TextBox txtToprakTipi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAkdeniz;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnToprakBilgisi;
        private System.Windows.Forms.Label label1;
    }
}