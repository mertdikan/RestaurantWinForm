
namespace WinUI
{
    partial class FormUrunKategori
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewKategori = new System.Windows.Forms.DataGridView();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSilKat = new System.Windows.Forms.Button();
            this.btnGuncelleKat = new System.Windows.Forms.Button();
            this.btnEkleKat = new System.Windows.Forms.Button();
            this.txtMenuId = new System.Windows.Forms.TextBox();
            this.txtKagetoriAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunAciklamasi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtKategoriId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewUrun = new System.Windows.Forms.DataGridView();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategori)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewKategori);
            this.tabPage1.Controls.Add(this.btnKategoriler);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(848, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kategori";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewKategori
            // 
            this.dataGridViewKategori.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategori.Location = new System.Drawing.Point(5, 0);
            this.dataGridViewKategori.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewKategori.Name = "dataGridViewKategori";
            this.dataGridViewKategori.RowHeadersWidth = 51;
            this.dataGridViewKategori.RowTemplate.Height = 24;
            this.dataGridViewKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKategori.Size = new System.Drawing.Size(838, 191);
            this.dataGridViewKategori.TabIndex = 9;
            this.dataGridViewKategori.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKategori_CellDoubleClick);
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.Location = new System.Drawing.Point(682, 209);
            this.btnKategoriler.Margin = new System.Windows.Forms.Padding(2);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(142, 38);
            this.btnKategoriler.TabIndex = 8;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSilKat);
            this.groupBox2.Controls.Add(this.btnGuncelleKat);
            this.groupBox2.Controls.Add(this.btnEkleKat);
            this.groupBox2.Controls.Add(this.txtMenuId);
            this.groupBox2.Controls.Add(this.txtKagetoriAdi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(5, 209);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(338, 192);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategori";
            // 
            // btnSilKat
            // 
            this.btnSilKat.Location = new System.Drawing.Point(228, 136);
            this.btnSilKat.Margin = new System.Windows.Forms.Padding(2);
            this.btnSilKat.Name = "btnSilKat";
            this.btnSilKat.Size = new System.Drawing.Size(78, 29);
            this.btnSilKat.TabIndex = 10;
            this.btnSilKat.Text = "Sil";
            this.btnSilKat.UseVisualStyleBackColor = true;
            this.btnSilKat.Click += new System.EventHandler(this.btnSilKat_Click);
            // 
            // btnGuncelleKat
            // 
            this.btnGuncelleKat.Location = new System.Drawing.Point(106, 136);
            this.btnGuncelleKat.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelleKat.Name = "btnGuncelleKat";
            this.btnGuncelleKat.Size = new System.Drawing.Size(101, 28);
            this.btnGuncelleKat.TabIndex = 9;
            this.btnGuncelleKat.Text = "Guncelle";
            this.btnGuncelleKat.UseVisualStyleBackColor = true;
            this.btnGuncelleKat.Click += new System.EventHandler(this.btnGuncelleKat_Click);
            // 
            // btnEkleKat
            // 
            this.btnEkleKat.Location = new System.Drawing.Point(19, 136);
            this.btnEkleKat.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkleKat.Name = "btnEkleKat";
            this.btnEkleKat.Size = new System.Drawing.Size(69, 29);
            this.btnEkleKat.TabIndex = 8;
            this.btnEkleKat.Text = "EKLE";
            this.btnEkleKat.UseVisualStyleBackColor = true;
            this.btnEkleKat.Click += new System.EventHandler(this.btnEkleKat_Click);
            // 
            // txtMenuId
            // 
            this.txtMenuId.Location = new System.Drawing.Point(157, 65);
            this.txtMenuId.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenuId.Name = "txtMenuId";
            this.txtMenuId.Size = new System.Drawing.Size(115, 22);
            this.txtMenuId.TabIndex = 5;
            // 
            // txtKagetoriAdi
            // 
            this.txtKagetoriAdi.Location = new System.Drawing.Point(157, 33);
            this.txtKagetoriAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKagetoriAdi.Name = "txtKagetoriAdi";
            this.txtKagetoriAdi.Size = new System.Drawing.Size(115, 22);
            this.txtKagetoriAdi.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "MenuId";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kategori Adı";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.dataGridViewUrun);
            this.tabPage2.Controls.Add(this.btnUrunler);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(848, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürünler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtFiyat);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtUrunAciklamasi);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnUrunSil);
            this.groupBox3.Controls.Add(this.btnUrunGuncelle);
            this.groupBox3.Controls.Add(this.btnUrunEkle);
            this.groupBox3.Controls.Add(this.txtUrunAdi);
            this.groupBox3.Controls.Add(this.txtKategoriId);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(24, 207);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(352, 252);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Urun";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(179, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 19);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Durum";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(179, 135);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(120, 21);
            this.txtFiyat.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fiyat";
            // 
            // txtUrunAciklamasi
            // 
            this.txtUrunAciklamasi.Location = new System.Drawing.Point(179, 98);
            this.txtUrunAciklamasi.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunAciklamasi.Name = "txtUrunAciklamasi";
            this.txtUrunAciklamasi.Size = new System.Drawing.Size(120, 21);
            this.txtUrunAciklamasi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Urun Acıklaması";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(216, 209);
            this.btnUrunSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(83, 39);
            this.btnUrunSil.TabIndex = 10;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(116, 209);
            this.btnUrunGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(73, 39);
            this.btnUrunGuncelle.TabIndex = 9;
            this.btnUrunGuncelle.Text = "Guncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(22, 209);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(56, 39);
            this.btnUrunEkle.TabIndex = 8;
            this.btnUrunEkle.Text = "EKLE";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(179, 68);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(120, 21);
            this.txtUrunAdi.TabIndex = 5;
            // 
            // txtKategoriId
            // 
            this.txtKategoriId.Location = new System.Drawing.Point(179, 36);
            this.txtKategoriId.Margin = new System.Windows.Forms.Padding(2);
            this.txtKategoriId.Name = "txtKategoriId";
            this.txtKategoriId.Size = new System.Drawing.Size(120, 21);
            this.txtKategoriId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Urun Adi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "KategoriId";
            // 
            // dataGridViewUrun
            // 
            this.dataGridViewUrun.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrun.Location = new System.Drawing.Point(4, 5);
            this.dataGridViewUrun.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUrun.Name = "dataGridViewUrun";
            this.dataGridViewUrun.RowHeadersWidth = 51;
            this.dataGridViewUrun.RowTemplate.Height = 24;
            this.dataGridViewUrun.Size = new System.Drawing.Size(840, 187);
            this.dataGridViewUrun.TabIndex = 11;
            this.dataGridViewUrun.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUrun_CellDoubleClick);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Location = new System.Drawing.Point(690, 227);
            this.btnUrunler.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(135, 46);
            this.btnUrunler.TabIndex = 10;
            this.btnUrunler.Text = "Urunler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // FormUrunKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 508);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormUrunKategori";
            this.Text = "FormUrunKategori";
            this.Load += new System.EventHandler(this.FormUrunKategori_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategori)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewKategori;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSilKat;
        private System.Windows.Forms.Button btnGuncelleKat;
        private System.Windows.Forms.Button btnEkleKat;
        private System.Windows.Forms.TextBox txtMenuId;
        private System.Windows.Forms.TextBox txtKagetoriAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrunAciklamasi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtKategoriId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewUrun;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}