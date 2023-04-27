
namespace WinUI
{
    partial class FormMusteriSiparis
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
            this.txtMusteriAdiAra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnMusteriGetir = new System.Windows.Forms.Button();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.txtMusteriTel = new System.Windows.Forms.TextBox();
            this.txtMusteriAdres = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyadi = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMusteri = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSiparisGetir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSipTuru = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSiparisCalisanId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSiparisMusteriId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSiparisSil = new System.Windows.Forms.Button();
            this.btnSiparisGuncelle = new System.Windows.Forms.Button();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.txtSiparisMasaNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewSiparis = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtMusteriAdiAra);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnMusteriGetir);
            this.tabPage1.Controls.Add(this.groupbox1);
            this.tabPage1.Controls.Add(this.dataGridViewMusteri);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Musteri";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtMusteriAdiAra
            // 
            this.txtMusteriAdiAra.Location = new System.Drawing.Point(644, 257);
            this.txtMusteriAdiAra.Name = "txtMusteriAdiAra";
            this.txtMusteriAdiAra.Size = new System.Drawing.Size(143, 20);
            this.txtMusteriAdiAra.TabIndex = 17;
            this.txtMusteriAdiAra.TextChanged += new System.EventHandler(this.txtMusteriAdiAra_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(501, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Müşteri Adı Arama";
            // 
            // btnMusteriGetir
            // 
            this.btnMusteriGetir.Location = new System.Drawing.Point(629, 302);
            this.btnMusteriGetir.Name = "btnMusteriGetir";
            this.btnMusteriGetir.Size = new System.Drawing.Size(170, 34);
            this.btnMusteriGetir.TabIndex = 1;
            this.btnMusteriGetir.Text = "Müşterileri Getir";
            this.btnMusteriGetir.UseVisualStyleBackColor = true;
            this.btnMusteriGetir.Click += new System.EventHandler(this.btnMusteriGetir_Click);
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.btnMusteriSil);
            this.groupbox1.Controls.Add(this.btnMusteriGuncelle);
            this.groupbox1.Controls.Add(this.btnMusteriEkle);
            this.groupbox1.Controls.Add(this.txtMusteriTel);
            this.groupbox1.Controls.Add(this.txtMusteriAdres);
            this.groupbox1.Controls.Add(this.txtMusteriSoyadi);
            this.groupbox1.Controls.Add(this.txtMusteriAdi);
            this.groupbox1.Controls.Add(this.label4);
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Location = new System.Drawing.Point(16, 223);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(330, 205);
            this.groupbox1.TabIndex = 1;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Musteri";
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(221, 176);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriSil.TabIndex = 10;
            this.btnMusteriSil.Text = "SİL";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(122, 176);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriGuncelle.TabIndex = 9;
            this.btnMusteriGuncelle.Text = "GUNCELLE";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(32, 176);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriEkle.TabIndex = 8;
            this.btnMusteriEkle.Text = "EKLE";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // txtMusteriTel
            // 
            this.txtMusteriTel.Location = new System.Drawing.Point(111, 126);
            this.txtMusteriTel.Name = "txtMusteriTel";
            this.txtMusteriTel.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriTel.TabIndex = 7;
            // 
            // txtMusteriAdres
            // 
            this.txtMusteriAdres.Location = new System.Drawing.Point(111, 100);
            this.txtMusteriAdres.Name = "txtMusteriAdres";
            this.txtMusteriAdres.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriAdres.TabIndex = 5;
            // 
            // txtMusteriSoyadi
            // 
            this.txtMusteriSoyadi.Location = new System.Drawing.Point(111, 68);
            this.txtMusteriSoyadi.Name = "txtMusteriSoyadi";
            this.txtMusteriSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriSoyadi.TabIndex = 3;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(111, 34);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriAdi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı";
            // 
            // dataGridViewMusteri
            // 
            this.dataGridViewMusteri.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteri.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewMusteri.Name = "dataGridViewMusteri";
            this.dataGridViewMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMusteri.Size = new System.Drawing.Size(813, 209);
            this.dataGridViewMusteri.TabIndex = 0;
            this.dataGridViewMusteri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMusteri_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSiparisGetir);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridViewSiparis);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Siparis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSiparisGetir
            // 
            this.btnSiparisGetir.Location = new System.Drawing.Point(650, 232);
            this.btnSiparisGetir.Name = "btnSiparisGetir";
            this.btnSiparisGetir.Size = new System.Drawing.Size(170, 34);
            this.btnSiparisGetir.TabIndex = 12;
            this.btnSiparisGetir.Text = "Siparişleri Getir";
            this.btnSiparisGetir.UseVisualStyleBackColor = true;
            this.btnSiparisGetir.Click += new System.EventHandler(this.btnSiparisGetir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxSipTuru);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txtSiparisCalisanId);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSiparisMusteriId);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnSiparisSil);
            this.groupBox2.Controls.Add(this.btnSiparisGuncelle);
            this.groupBox2.Controls.Add(this.btnSiparisEkle);
            this.groupBox2.Controls.Add(this.txtSiparisMasaNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(15, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 233);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Siparis";
            // 
            // checkBoxSipTuru
            // 
            this.checkBoxSipTuru.AutoSize = true;
            this.checkBoxSipTuru.Location = new System.Drawing.Point(111, 69);
            this.checkBoxSipTuru.Name = "checkBoxSipTuru";
            this.checkBoxSipTuru.Size = new System.Drawing.Size(80, 17);
            this.checkBoxSipTuru.TabIndex = 17;
            this.checkBoxSipTuru.Text = "checkBox1";
            this.checkBoxSipTuru.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(111, 43);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // txtSiparisCalisanId
            // 
            this.txtSiparisCalisanId.Location = new System.Drawing.Point(111, 166);
            this.txtSiparisCalisanId.Name = "txtSiparisCalisanId";
            this.txtSiparisCalisanId.Size = new System.Drawing.Size(100, 20);
            this.txtSiparisCalisanId.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "CalisanId";
            // 
            // txtSiparisMusteriId
            // 
            this.txtSiparisMusteriId.Location = new System.Drawing.Point(111, 133);
            this.txtSiparisMusteriId.Name = "txtSiparisMusteriId";
            this.txtSiparisMusteriId.Size = new System.Drawing.Size(100, 20);
            this.txtSiparisMusteriId.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "MusteriId";
            // 
            // btnSiparisSil
            // 
            this.btnSiparisSil.Location = new System.Drawing.Point(209, 204);
            this.btnSiparisSil.Name = "btnSiparisSil";
            this.btnSiparisSil.Size = new System.Drawing.Size(75, 23);
            this.btnSiparisSil.TabIndex = 10;
            this.btnSiparisSil.Text = "SİL";
            this.btnSiparisSil.UseVisualStyleBackColor = true;
            this.btnSiparisSil.Click += new System.EventHandler(this.btnSiparisSil_Click);
            // 
            // btnSiparisGuncelle
            // 
            this.btnSiparisGuncelle.Location = new System.Drawing.Point(113, 204);
            this.btnSiparisGuncelle.Name = "btnSiparisGuncelle";
            this.btnSiparisGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnSiparisGuncelle.TabIndex = 9;
            this.btnSiparisGuncelle.Text = "GUNCELLE";
            this.btnSiparisGuncelle.UseVisualStyleBackColor = true;
            this.btnSiparisGuncelle.Click += new System.EventHandler(this.btnSiparisGuncelle_Click);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(21, 204);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSiparisEkle.TabIndex = 8;
            this.btnSiparisEkle.Text = "EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // txtSiparisMasaNo
            // 
            this.txtSiparisMasaNo.Location = new System.Drawing.Point(111, 100);
            this.txtSiparisMasaNo.Name = "txtSiparisMasaNo";
            this.txtSiparisMasaNo.Size = new System.Drawing.Size(100, 20);
            this.txtSiparisMasaNo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Masa Numarası";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Siparis Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Teslim Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Siparis Tarihi";
            // 
            // dataGridViewSiparis
            // 
            this.dataGridViewSiparis.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparis.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewSiparis.Name = "dataGridViewSiparis";
            this.dataGridViewSiparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSiparis.Size = new System.Drawing.Size(814, 209);
            this.dataGridViewSiparis.TabIndex = 10;
            this.dataGridViewSiparis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSiparis_CellDoubleClick);
            // 
            // FormMusteriSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 491);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMusteriSiparis";
            this.Text = "FormMusteriSiparis";
            this.Load += new System.EventHandler(this.FormMusteriSiparis_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewMusteri;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnMusteriGetir;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.TextBox txtMusteriTel;
        private System.Windows.Forms.TextBox txtMusteriAdres;
        private System.Windows.Forms.TextBox txtMusteriSoyadi;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiparisGetir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSiparisSil;
        private System.Windows.Forms.Button btnSiparisGuncelle;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.TextBox txtSiparisMasaNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewSiparis;
        private System.Windows.Forms.CheckBox checkBoxSipTuru;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSiparisCalisanId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSiparisMusteriId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMusteriAdiAra;
        private System.Windows.Forms.Label label11;
    }
}