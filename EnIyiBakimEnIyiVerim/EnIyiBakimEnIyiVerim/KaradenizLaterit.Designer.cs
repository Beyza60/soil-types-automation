
namespace EnIyiBakimEnIyiVerim
{
    partial class KaradenizLaterit
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
            this.lVEnCokU = new System.Windows.Forms.ListView();
            this.lVGenelOzellikleri = new System.Windows.Forms.ListView();
            this.btnEnCokUretilenler = new System.Windows.Forms.Button();
            this.btnGenelOzellikler = new System.Windows.Forms.Button();
            this.btnGeneldeUretilenler = new System.Windows.Forms.Button();
            this.lVGeneldeUretilenler = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lVEnCokU
            // 
            this.lVEnCokU.HideSelection = false;
            this.lVEnCokU.Location = new System.Drawing.Point(12, 126);
            this.lVEnCokU.Name = "lVEnCokU";
            this.lVEnCokU.Size = new System.Drawing.Size(164, 236);
            this.lVEnCokU.TabIndex = 0;
            this.lVEnCokU.UseCompatibleStateImageBehavior = false;
            this.lVEnCokU.View = System.Windows.Forms.View.SmallIcon;
            // 
            // lVGenelOzellikleri
            // 
            this.lVGenelOzellikleri.HideSelection = false;
            this.lVGenelOzellikleri.Location = new System.Drawing.Point(240, 145);
            this.lVGenelOzellikleri.Name = "lVGenelOzellikleri";
            this.lVGenelOzellikleri.Size = new System.Drawing.Size(316, 152);
            this.lVGenelOzellikleri.TabIndex = 1;
            this.lVGenelOzellikleri.UseCompatibleStateImageBehavior = false;
            this.lVGenelOzellikleri.View = System.Windows.Forms.View.List;
            // 
            // btnEnCokUretilenler
            // 
            this.btnEnCokUretilenler.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEnCokUretilenler.Location = new System.Drawing.Point(12, 72);
            this.btnEnCokUretilenler.Name = "btnEnCokUretilenler";
            this.btnEnCokUretilenler.Size = new System.Drawing.Size(151, 48);
            this.btnEnCokUretilenler.TabIndex = 2;
            this.btnEnCokUretilenler.Text = "En Çok yetiştirilen ürünler";
            this.btnEnCokUretilenler.UseVisualStyleBackColor = false;
            this.btnEnCokUretilenler.Click += new System.EventHandler(this.btnEnCokUretilenler_Click);
            // 
            // btnGenelOzellikler
            // 
            this.btnGenelOzellikler.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGenelOzellikler.Location = new System.Drawing.Point(240, 110);
            this.btnGenelOzellikler.Name = "btnGenelOzellikler";
            this.btnGenelOzellikler.Size = new System.Drawing.Size(316, 29);
            this.btnGenelOzellikler.TabIndex = 3;
            this.btnGenelOzellikler.Text = "Toprak Tipinin Genel Özellikleri";
            this.btnGenelOzellikler.UseVisualStyleBackColor = false;
            this.btnGenelOzellikler.Click += new System.EventHandler(this.btnGenelOzellikler_Click);
            // 
            // btnGeneldeUretilenler
            // 
            this.btnGeneldeUretilenler.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGeneldeUretilenler.Location = new System.Drawing.Point(637, 72);
            this.btnGeneldeUretilenler.Name = "btnGeneldeUretilenler";
            this.btnGeneldeUretilenler.Size = new System.Drawing.Size(151, 48);
            this.btnGeneldeUretilenler.TabIndex = 4;
            this.btnGeneldeUretilenler.Text = "Bu Toprakta üretilen diğer ürünler";
            this.btnGeneldeUretilenler.UseVisualStyleBackColor = false;
            this.btnGeneldeUretilenler.Click += new System.EventHandler(this.btnGeneldeUretilenler_Click);
            // 
            // lVGeneldeUretilenler
            // 
            this.lVGeneldeUretilenler.HideSelection = false;
            this.lVGeneldeUretilenler.Location = new System.Drawing.Point(637, 126);
            this.lVGeneldeUretilenler.Name = "lVGeneldeUretilenler";
            this.lVGeneldeUretilenler.Size = new System.Drawing.Size(151, 312);
            this.lVGeneldeUretilenler.TabIndex = 5;
            this.lVGeneldeUretilenler.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Chiller", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(214, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bilgi almak istediğiniz konuları görmek için ilgili yazıya tıklayınız:)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(292, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "~~LATERİT TOPRAK~~";
            // 
            // KaradenizLaterit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lVGeneldeUretilenler);
            this.Controls.Add(this.btnGeneldeUretilenler);
            this.Controls.Add(this.btnGenelOzellikler);
            this.Controls.Add(this.btnEnCokUretilenler);
            this.Controls.Add(this.lVGenelOzellikleri);
            this.Controls.Add(this.lVEnCokU);
            this.Name = "KaradenizLaterit";
            this.Text = "KaradenizLaterit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lVEnCokU;
        private System.Windows.Forms.ListView lVGenelOzellikleri;
        private System.Windows.Forms.Button btnEnCokUretilenler;
        private System.Windows.Forms.Button btnGenelOzellikler;
        private System.Windows.Forms.Button btnGeneldeUretilenler;
        private System.Windows.Forms.ListView lVGeneldeUretilenler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}