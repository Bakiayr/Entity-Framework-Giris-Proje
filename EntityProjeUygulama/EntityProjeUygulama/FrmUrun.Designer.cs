
namespace EntityProjeUygulama
{
    partial class FrmUrun
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_urunID = new System.Windows.Forms.TextBox();
            this.txt_urunAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_urunMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_urunStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_urunFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_urunDurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_urunKategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün ID:";
            // 
            // txt_urunID
            // 
            this.txt_urunID.Location = new System.Drawing.Point(104, 6);
            this.txt_urunID.Name = "txt_urunID";
            this.txt_urunID.Size = new System.Drawing.Size(160, 27);
            this.txt_urunID.TabIndex = 1;
            // 
            // txt_urunAd
            // 
            this.txt_urunAd.Location = new System.Drawing.Point(104, 39);
            this.txt_urunAd.Name = "txt_urunAd";
            this.txt_urunAd.Size = new System.Drawing.Size(160, 27);
            this.txt_urunAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı:";
            // 
            // txt_urunMarka
            // 
            this.txt_urunMarka.Location = new System.Drawing.Point(104, 72);
            this.txt_urunMarka.Name = "txt_urunMarka";
            this.txt_urunMarka.Size = new System.Drawing.Size(160, 27);
            this.txt_urunMarka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marka:";
            // 
            // txt_urunStok
            // 
            this.txt_urunStok.Location = new System.Drawing.Point(104, 105);
            this.txt_urunStok.Name = "txt_urunStok";
            this.txt_urunStok.Size = new System.Drawing.Size(160, 27);
            this.txt_urunStok.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stok:";
            // 
            // txt_urunFiyat
            // 
            this.txt_urunFiyat.Location = new System.Drawing.Point(104, 138);
            this.txt_urunFiyat.Name = "txt_urunFiyat";
            this.txt_urunFiyat.Size = new System.Drawing.Size(160, 27);
            this.txt_urunFiyat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyat:";
            // 
            // txt_urunDurum
            // 
            this.txt_urunDurum.Location = new System.Drawing.Point(104, 171);
            this.txt_urunDurum.Name = "txt_urunDurum";
            this.txt_urunDurum.Size = new System.Drawing.Size(160, 27);
            this.txt_urunDurum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kategori:";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(346, 12);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(162, 38);
            this.btn_Ekle.TabIndex = 14;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(346, 144);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(162, 38);
            this.btn_Listele.TabIndex = 15;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(346, 100);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(162, 38);
            this.btn_Guncelle.TabIndex = 16;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(346, 56);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(162, 38);
            this.btn_Sil.TabIndex = 17;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(346, 188);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(162, 38);
            this.btn_Temizle.TabIndex = 18;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 167);
            this.dataGridView1.TabIndex = 19;
            // 
            // cmb_urunKategori
            // 
            this.cmb_urunKategori.FormattingEnabled = true;
            this.cmb_urunKategori.Location = new System.Drawing.Point(104, 204);
            this.cmb_urunKategori.Name = "cmb_urunKategori";
            this.cmb_urunKategori.Size = new System.Drawing.Size(160, 27);
            this.cmb_urunKategori.TabIndex = 20;
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 416);
            this.Controls.Add(this.cmb_urunKategori);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_urunDurum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_urunFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_urunStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_urunMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_urunAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_urunID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_urunID;
        private System.Windows.Forms.TextBox txt_urunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_urunMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_urunStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_urunFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_urunDurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_urunKategori;
    }
}