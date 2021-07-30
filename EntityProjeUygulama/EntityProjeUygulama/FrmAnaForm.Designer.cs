
namespace EntityProjeUygulama
{
    partial class FrmAnaForm
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
            this.btn_Kategori = new System.Windows.Forms.Button();
            this.btn_Urun = new System.Windows.Forms.Button();
            this.btn_Istatistik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Kategori
            // 
            this.btn_Kategori.Location = new System.Drawing.Point(12, 12);
            this.btn_Kategori.Name = "btn_Kategori";
            this.btn_Kategori.Size = new System.Drawing.Size(175, 148);
            this.btn_Kategori.TabIndex = 0;
            this.btn_Kategori.Text = "KATEGORİ İŞLEMLERİ";
            this.btn_Kategori.UseVisualStyleBackColor = true;
            this.btn_Kategori.Click += new System.EventHandler(this.btn_Kategori_Click);
            // 
            // btn_Urun
            // 
            this.btn_Urun.Location = new System.Drawing.Point(193, 12);
            this.btn_Urun.Name = "btn_Urun";
            this.btn_Urun.Size = new System.Drawing.Size(175, 148);
            this.btn_Urun.TabIndex = 1;
            this.btn_Urun.Text = "ÜRÜN İŞLEMLERİ";
            this.btn_Urun.UseVisualStyleBackColor = true;
            this.btn_Urun.Click += new System.EventHandler(this.btn_Urun_Click);
            // 
            // btn_Istatistik
            // 
            this.btn_Istatistik.Location = new System.Drawing.Point(374, 12);
            this.btn_Istatistik.Name = "btn_Istatistik";
            this.btn_Istatistik.Size = new System.Drawing.Size(175, 148);
            this.btn_Istatistik.TabIndex = 2;
            this.btn_Istatistik.Text = "İSTATİSTİKLER";
            this.btn_Istatistik.UseVisualStyleBackColor = true;
            this.btn_Istatistik.Click += new System.EventHandler(this.btn_Istatistik_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 172);
            this.Controls.Add(this.btn_Istatistik);
            this.Controls.Add(this.btn_Urun);
            this.Controls.Add(this.btn_Kategori);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Kategori;
        private System.Windows.Forms.Button btn_Urun;
        private System.Windows.Forms.Button btn_Istatistik;
    }
}