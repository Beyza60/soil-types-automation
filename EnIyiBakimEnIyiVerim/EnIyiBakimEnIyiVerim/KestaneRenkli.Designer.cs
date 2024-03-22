
namespace EnIyiBakimEnIyiVerim
{
    partial class KestaneRenkli
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lVGeneldeU = new System.Windows.Forms.ListView();
            this.btnUretilenDigerU = new System.Windows.Forms.Button();
            this.btnGenelOzellikler = new System.Windows.Forms.Button();
            this.btnEnCokU = new System.Windows.Forms.Button();
            this.lVGenelOzellikler = new System.Windows.Forms.ListView();
            this.lVPodzolEnCokU = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(292, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "~~KESTANE RENKLİ TOPRAK~~";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Chiller", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(214, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Bilgi almak istediğiniz konuları görmek için ilgili yazıya tıklayınız:)";
            // 
            // lVGeneldeU
            // 
            this.lVGeneldeU.HideSelection = false;
            this.lVGeneldeU.Location = new System.Drawing.Point(637, 115);
            this.lVGeneldeU.Name = "lVGeneldeU";
            this.lVGeneldeU.Size = new System.Drawing.Size(151, 312);
            this.lVGeneldeU.TabIndex = 29;
            this.lVGeneldeU.UseCompatibleStateImageBehavior = false;
            // 
            // btnUretilenDigerU
            // 
            this.btnUretilenDigerU.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUretilenDigerU.Location = new System.Drawing.Point(637, 61);
            this.btnUretilenDigerU.Name = "btnUretilenDigerU";
            this.btnUretilenDigerU.Size = new System.Drawing.Size(151, 48);
            this.btnUretilenDigerU.TabIndex = 28;
            this.btnUretilenDigerU.Text = "Bu Toprakta üretilen diğer ürünler";
            this.btnUretilenDigerU.UseVisualStyleBackColor = false;
            this.btnUretilenDigerU.Click += new System.EventHandler(this.btnUretilenDigerU_Click);
            // 
            // btnGenelOzellikler
            // 
            this.btnGenelOzellikler.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGenelOzellikler.Location = new System.Drawing.Point(240, 99);
            this.btnGenelOzellikler.Name = "btnGenelOzellikler";
            this.btnGenelOzellikler.Size = new System.Drawing.Size(316, 29);
            this.btnGenelOzellikler.TabIndex = 27;
            this.btnGenelOzellikler.Text = "Toprak Tipinin Genel Özellikleri";
            this.btnGenelOzellikler.UseVisualStyleBackColor = false;
            this.btnGenelOzellikler.Click += new System.EventHandler(this.btnGenelOzellikler_Click);
            // 
            // btnEnCokU
            // 
            this.btnEnCokU.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEnCokU.Location = new System.Drawing.Point(12, 61);
            this.btnEnCokU.Name = "btnEnCokU";
            this.btnEnCokU.Size = new System.Drawing.Size(151, 48);
            this.btnEnCokU.TabIndex = 26;
            this.btnEnCokU.Text = "En Çok yetiştirilen ürünler";
            this.btnEnCokU.UseVisualStyleBackColor = false;
            this.btnEnCokU.Click += new System.EventHandler(this.btnEnCokU_Click);
            // 
            // lVGenelOzellikler
            // 
            this.lVGenelOzellikler.HideSelection = false;
            this.lVGenelOzellikler.Location = new System.Drawing.Point(240, 134);
            this.lVGenelOzellikler.Name = "lVGenelOzellikler";
            this.lVGenelOzellikler.Size = new System.Drawing.Size(316, 152);
            this.lVGenelOzellikler.TabIndex = 25;
            this.lVGenelOzellikler.UseCompatibleStateImageBehavior = false;
            this.lVGenelOzellikler.View = System.Windows.Forms.View.List;
            // 
            // lVPodzolEnCokU
            // 
            this.lVPodzolEnCokU.HideSelection = false;
            this.lVPodzolEnCokU.Location = new System.Drawing.Point(12, 134);
            this.lVPodzolEnCokU.Name = "lVPodzolEnCokU";
            this.lVPodzolEnCokU.Size = new System.Drawing.Size(164, 236);
            this.lVPodzolEnCokU.TabIndex = 24;
            this.lVPodzolEnCokU.UseCompatibleStateImageBehavior = false;
            this.lVPodzolEnCokU.View = System.Windows.Forms.View.SmallIcon;
            // 
            // KestaneRenkli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lVGeneldeU);
            this.Controls.Add(this.btnUretilenDigerU);
            this.Controls.Add(this.btnGenelOzellikler);
            this.Controls.Add(this.btnEnCokU);
            this.Controls.Add(this.lVGenelOzellikler);
            this.Controls.Add(this.lVPodzolEnCokU);
            this.Name = "KestaneRenkli";
            this.Text = "KestaneRenkli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lVGeneldeU;
        private System.Windows.Forms.Button btnUretilenDigerU;
        private System.Windows.Forms.Button btnGenelOzellikler;
        private System.Windows.Forms.Button btnEnCokU;
        private System.Windows.Forms.ListView lVGenelOzellikler;
        private System.Windows.Forms.ListView lVPodzolEnCokU;
    }
}