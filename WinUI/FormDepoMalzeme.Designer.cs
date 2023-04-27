
namespace WinUI
{
    partial class FormDepoMalzeme
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
            this.txtDepoArama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDepoGetir = new System.Windows.Forms.Button();
            this.dataGridViewDepo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDepoAdres = new System.Windows.Forms.TextBox();
            this.txtDepoAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDepoSil = new System.Windows.Forms.Button();
            this.btnDepoGuncelle = new System.Windows.Forms.Button();
            this.btnDepoEkle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtMalzemeAdiAra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMalzemeGetir = new System.Windows.Forms.Button();
            this.dataGridViewMalzeme = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMalTedId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkboxMalDurum = new System.Windows.Forms.CheckBox();
            this.txtMalKatId = new System.Windows.Forms.TextBox();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMalzemeSil = new System.Windows.Forms.Button();
            this.btnMalzemeGuncelle = new System.Windows.Forms.Button();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnMalKategoriGetir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMalKategoriSil = new System.Windows.Forms.Button();
            this.btnMalKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnMalKategoriEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMalKatAdi = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewMalzemeKategori = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTedarikciGetir = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTedarikciSil = new System.Windows.Forms.Button();
            this.btnTedarikciGuncelle = new System.Windows.Forms.Button();
            this.btnTedarikciEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTedarikciAdi = new System.Windows.Forms.TextBox();
            this.dataGridViewTedarikci = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalzeme)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalzemeKategori)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTedarikci)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDepoArama);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnDepoGetir);
            this.tabPage1.Controls.Add(this.dataGridViewDepo);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(805, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Depo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDepoArama
            // 
            this.txtDepoArama.Location = new System.Drawing.Point(645, 204);
            this.txtDepoArama.Name = "txtDepoArama";
            this.txtDepoArama.Size = new System.Drawing.Size(143, 20);
            this.txtDepoArama.TabIndex = 13;
            this.txtDepoArama.TextChanged += new System.EventHandler(this.txtDepoArama_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(541, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Depo Arama";
            // 
            // btnDepoGetir
            // 
            this.btnDepoGetir.Location = new System.Drawing.Point(628, 345);
            this.btnDepoGetir.Name = "btnDepoGetir";
            this.btnDepoGetir.Size = new System.Drawing.Size(171, 36);
            this.btnDepoGetir.TabIndex = 2;
            this.btnDepoGetir.Text = "Depoları Getir";
            this.btnDepoGetir.UseVisualStyleBackColor = true;
            this.btnDepoGetir.Click += new System.EventHandler(this.btnDepoGetir_Click);
            // 
            // dataGridViewDepo
            // 
            this.dataGridViewDepo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepo.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewDepo.Name = "dataGridViewDepo";
            this.dataGridViewDepo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepo.Size = new System.Drawing.Size(795, 167);
            this.dataGridViewDepo.TabIndex = 1;
            this.dataGridViewDepo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepo_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDepoAdres);
            this.groupBox1.Controls.Add(this.txtDepoAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDepoSil);
            this.groupBox1.Controls.Add(this.btnDepoGuncelle);
            this.groupBox1.Controls.Add(this.btnDepoEkle);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depo";
            // 
            // txtDepoAdres
            // 
            this.txtDepoAdres.Location = new System.Drawing.Point(110, 74);
            this.txtDepoAdres.Name = "txtDepoAdres";
            this.txtDepoAdres.Size = new System.Drawing.Size(142, 21);
            this.txtDepoAdres.TabIndex = 9;
            // 
            // txtDepoAdi
            // 
            this.txtDepoAdi.Location = new System.Drawing.Point(110, 33);
            this.txtDepoAdi.Name = "txtDepoAdi";
            this.txtDepoAdi.Size = new System.Drawing.Size(142, 21);
            this.txtDepoAdi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Depo Adı";
            // 
            // btnDepoSil
            // 
            this.btnDepoSil.Location = new System.Drawing.Point(240, 165);
            this.btnDepoSil.Name = "btnDepoSil";
            this.btnDepoSil.Size = new System.Drawing.Size(95, 36);
            this.btnDepoSil.TabIndex = 5;
            this.btnDepoSil.Text = "SİL";
            this.btnDepoSil.UseVisualStyleBackColor = true;
            this.btnDepoSil.Click += new System.EventHandler(this.btnDepoSil_Click);
            // 
            // btnDepoGuncelle
            // 
            this.btnDepoGuncelle.Location = new System.Drawing.Point(121, 164);
            this.btnDepoGuncelle.Name = "btnDepoGuncelle";
            this.btnDepoGuncelle.Size = new System.Drawing.Size(100, 36);
            this.btnDepoGuncelle.TabIndex = 4;
            this.btnDepoGuncelle.Text = "GUNCELLE";
            this.btnDepoGuncelle.UseVisualStyleBackColor = true;
            this.btnDepoGuncelle.Click += new System.EventHandler(this.btnDepoGuncelle_Click);
            // 
            // btnDepoEkle
            // 
            this.btnDepoEkle.Location = new System.Drawing.Point(6, 164);
            this.btnDepoEkle.Name = "btnDepoEkle";
            this.btnDepoEkle.Size = new System.Drawing.Size(92, 36);
            this.btnDepoEkle.TabIndex = 3;
            this.btnDepoEkle.Text = "EKLE";
            this.btnDepoEkle.UseVisualStyleBackColor = true;
            this.btnDepoEkle.Click += new System.EventHandler(this.btnDepoEkle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtMalzemeAdiAra);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnMalzemeGetir);
            this.tabPage2.Controls.Add(this.dataGridViewMalzeme);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(805, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Malzeme";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtMalzemeAdiAra
            // 
            this.txtMalzemeAdiAra.Location = new System.Drawing.Point(643, 192);
            this.txtMalzemeAdiAra.Name = "txtMalzemeAdiAra";
            this.txtMalzemeAdiAra.Size = new System.Drawing.Size(143, 20);
            this.txtMalzemeAdiAra.TabIndex = 15;
            this.txtMalzemeAdiAra.TextChanged += new System.EventHandler(this.txtMalzemeAdiAra_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(492, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Malzeme Adı Arama";
            // 
            // btnMalzemeGetir
            // 
            this.btnMalzemeGetir.Location = new System.Drawing.Point(612, 344);
            this.btnMalzemeGetir.Name = "btnMalzemeGetir";
            this.btnMalzemeGetir.Size = new System.Drawing.Size(171, 37);
            this.btnMalzemeGetir.TabIndex = 5;
            this.btnMalzemeGetir.Text = "Malzeme Getir";
            this.btnMalzemeGetir.UseVisualStyleBackColor = true;
            this.btnMalzemeGetir.Click += new System.EventHandler(this.btnMalzemeGetir_Click);
            // 
            // dataGridViewMalzeme
            // 
            this.dataGridViewMalzeme.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewMalzeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMalzeme.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewMalzeme.Name = "dataGridViewMalzeme";
            this.dataGridViewMalzeme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMalzeme.Size = new System.Drawing.Size(799, 167);
            this.dataGridViewMalzeme.TabIndex = 4;
            this.dataGridViewMalzeme.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMalzeme_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMalTedId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkboxMalDurum);
            this.groupBox2.Controls.Add(this.txtMalKatId);
            this.groupBox2.Controls.Add(this.txtMalzemeAdi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnMalzemeSil);
            this.groupBox2.Controls.Add(this.btnMalzemeGuncelle);
            this.groupBox2.Controls.Add(this.btnMalzemeEkle);
            this.groupBox2.Location = new System.Drawing.Point(15, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 213);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Malzeme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "TedarikciId";
            // 
            // txtMalTedId
            // 
            this.txtMalTedId.Location = new System.Drawing.Point(122, 125);
            this.txtMalTedId.Name = "txtMalTedId";
            this.txtMalTedId.Size = new System.Drawing.Size(100, 20);
            this.txtMalTedId.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "MalzemeKategoriId";
            // 
            // checkboxMalDurum
            // 
            this.checkboxMalDurum.AutoSize = true;
            this.checkboxMalDurum.Location = new System.Drawing.Point(122, 64);
            this.checkboxMalDurum.Name = "checkboxMalDurum";
            this.checkboxMalDurum.Size = new System.Drawing.Size(74, 17);
            this.checkboxMalDurum.TabIndex = 10;
            this.checkboxMalDurum.Text = "checkBox";
            this.checkboxMalDurum.UseVisualStyleBackColor = true;
            // 
            // txtMalKatId
            // 
            this.txtMalKatId.Location = new System.Drawing.Point(122, 98);
            this.txtMalKatId.Name = "txtMalKatId";
            this.txtMalKatId.Size = new System.Drawing.Size(100, 20);
            this.txtMalKatId.TabIndex = 9;
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(122, 26);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(100, 20);
            this.txtMalzemeAdi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Durum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Malzeme Adı";
            // 
            // btnMalzemeSil
            // 
            this.btnMalzemeSil.Location = new System.Drawing.Point(242, 165);
            this.btnMalzemeSil.Name = "btnMalzemeSil";
            this.btnMalzemeSil.Size = new System.Drawing.Size(91, 33);
            this.btnMalzemeSil.TabIndex = 5;
            this.btnMalzemeSil.Text = "SİL";
            this.btnMalzemeSil.UseVisualStyleBackColor = true;
            this.btnMalzemeSil.Click += new System.EventHandler(this.btnMalzemeSil_Click);
            // 
            // btnMalzemeGuncelle
            // 
            this.btnMalzemeGuncelle.Location = new System.Drawing.Point(122, 165);
            this.btnMalzemeGuncelle.Name = "btnMalzemeGuncelle";
            this.btnMalzemeGuncelle.Size = new System.Drawing.Size(100, 33);
            this.btnMalzemeGuncelle.TabIndex = 4;
            this.btnMalzemeGuncelle.Text = "GUNCELLE";
            this.btnMalzemeGuncelle.UseVisualStyleBackColor = true;
            this.btnMalzemeGuncelle.Click += new System.EventHandler(this.btnMalzemeGuncelle_Click);
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.Location = new System.Drawing.Point(6, 165);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(97, 33);
            this.btnMalzemeEkle.TabIndex = 3;
            this.btnMalzemeEkle.Text = "EKLE";
            this.btnMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnMalKategoriGetir);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.dataGridViewMalzemeKategori);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(805, 410);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "MalzemeKategori";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnMalKategoriGetir
            // 
            this.btnMalKategoriGetir.Location = new System.Drawing.Point(632, 302);
            this.btnMalKategoriGetir.Name = "btnMalKategoriGetir";
            this.btnMalKategoriGetir.Size = new System.Drawing.Size(157, 23);
            this.btnMalKategoriGetir.TabIndex = 5;
            this.btnMalKategoriGetir.Text = "Malzeme Kategori Getir";
            this.btnMalKategoriGetir.UseVisualStyleBackColor = true;
            this.btnMalKategoriGetir.Click += new System.EventHandler(this.btnMalKategoriGetir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMalKategoriSil);
            this.groupBox3.Controls.Add(this.btnMalKategoriGuncelle);
            this.groupBox3.Controls.Add(this.btnMalKategoriEkle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtMalKatAdi);
            this.groupBox3.Location = new System.Drawing.Point(16, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 184);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MalzemeKategori";
            // 
            // btnMalKategoriSil
            // 
            this.btnMalKategoriSil.Location = new System.Drawing.Point(212, 95);
            this.btnMalKategoriSil.Name = "btnMalKategoriSil";
            this.btnMalKategoriSil.Size = new System.Drawing.Size(91, 31);
            this.btnMalKategoriSil.TabIndex = 4;
            this.btnMalKategoriSil.Text = "SİL";
            this.btnMalKategoriSil.UseVisualStyleBackColor = true;
            this.btnMalKategoriSil.Click += new System.EventHandler(this.btnMalKategoriSil_Click);
            // 
            // btnMalKategoriGuncelle
            // 
            this.btnMalKategoriGuncelle.Location = new System.Drawing.Point(114, 95);
            this.btnMalKategoriGuncelle.Name = "btnMalKategoriGuncelle";
            this.btnMalKategoriGuncelle.Size = new System.Drawing.Size(92, 31);
            this.btnMalKategoriGuncelle.TabIndex = 3;
            this.btnMalKategoriGuncelle.Text = "GUNCELLE";
            this.btnMalKategoriGuncelle.UseVisualStyleBackColor = true;
            this.btnMalKategoriGuncelle.Click += new System.EventHandler(this.btnMalKategoriGuncelle_Click);
            // 
            // btnMalKategoriEkle
            // 
            this.btnMalKategoriEkle.Location = new System.Drawing.Point(19, 95);
            this.btnMalKategoriEkle.Name = "btnMalKategoriEkle";
            this.btnMalKategoriEkle.Size = new System.Drawing.Size(75, 31);
            this.btnMalKategoriEkle.TabIndex = 2;
            this.btnMalKategoriEkle.Text = "EKLE";
            this.btnMalKategoriEkle.UseVisualStyleBackColor = true;
            this.btnMalKategoriEkle.Click += new System.EventHandler(this.btnMalKategoriEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Malzeme Kategori Adı";
            // 
            // txtMalKatAdi
            // 
            this.txtMalKatAdi.Location = new System.Drawing.Point(150, 39);
            this.txtMalKatAdi.Name = "txtMalKatAdi";
            this.txtMalKatAdi.Size = new System.Drawing.Size(100, 20);
            this.txtMalKatAdi.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(668, 220);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // dataGridViewMalzemeKategori
            // 
            this.dataGridViewMalzemeKategori.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMalzemeKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMalzemeKategori.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewMalzemeKategori.Name = "dataGridViewMalzemeKategori";
            this.dataGridViewMalzemeKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMalzemeKategori.Size = new System.Drawing.Size(793, 196);
            this.dataGridViewMalzemeKategori.TabIndex = 0;
            this.dataGridViewMalzemeKategori.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMalzemeKategori_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnTedarikciGetir);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.dataGridViewTedarikci);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(805, 410);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Tedarikçi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnTedarikciGetir
            // 
            this.btnTedarikciGetir.Location = new System.Drawing.Point(638, 330);
            this.btnTedarikciGetir.Name = "btnTedarikciGetir";
            this.btnTedarikciGetir.Size = new System.Drawing.Size(146, 35);
            this.btnTedarikciGetir.TabIndex = 9;
            this.btnTedarikciGetir.Text = "Tedarikci Getir";
            this.btnTedarikciGetir.UseVisualStyleBackColor = true;
            this.btnTedarikciGetir.Click += new System.EventHandler(this.btnTedarikciGetir_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTedarikciSil);
            this.groupBox4.Controls.Add(this.btnTedarikciGuncelle);
            this.groupBox4.Controls.Add(this.btnTedarikciEkle);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtTedarikciAdi);
            this.groupBox4.Location = new System.Drawing.Point(20, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 184);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tedarikci";
            // 
            // btnTedarikciSil
            // 
            this.btnTedarikciSil.Location = new System.Drawing.Point(206, 110);
            this.btnTedarikciSil.Name = "btnTedarikciSil";
            this.btnTedarikciSil.Size = new System.Drawing.Size(88, 35);
            this.btnTedarikciSil.TabIndex = 4;
            this.btnTedarikciSil.Text = "SİL";
            this.btnTedarikciSil.UseVisualStyleBackColor = true;
            this.btnTedarikciSil.Click += new System.EventHandler(this.btnTedarikciSil_Click);
            // 
            // btnTedarikciGuncelle
            // 
            this.btnTedarikciGuncelle.Location = new System.Drawing.Point(108, 110);
            this.btnTedarikciGuncelle.Name = "btnTedarikciGuncelle";
            this.btnTedarikciGuncelle.Size = new System.Drawing.Size(92, 35);
            this.btnTedarikciGuncelle.TabIndex = 3;
            this.btnTedarikciGuncelle.Text = "GUNCELLE";
            this.btnTedarikciGuncelle.UseVisualStyleBackColor = true;
            this.btnTedarikciGuncelle.Click += new System.EventHandler(this.btnTedarikciGuncelle_Click);
            // 
            // btnTedarikciEkle
            // 
            this.btnTedarikciEkle.Location = new System.Drawing.Point(18, 110);
            this.btnTedarikciEkle.Name = "btnTedarikciEkle";
            this.btnTedarikciEkle.Size = new System.Drawing.Size(84, 35);
            this.btnTedarikciEkle.TabIndex = 2;
            this.btnTedarikciEkle.Text = "EKLE";
            this.btnTedarikciEkle.UseVisualStyleBackColor = true;
            this.btnTedarikciEkle.Click += new System.EventHandler(this.btnTedarikciEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tedarikci Adı";
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(100, 34);
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtTedarikciAdi.TabIndex = 0;
            // 
            // dataGridViewTedarikci
            // 
            this.dataGridViewTedarikci.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewTedarikci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTedarikci.Location = new System.Drawing.Point(10, 6);
            this.dataGridViewTedarikci.Name = "dataGridViewTedarikci";
            this.dataGridViewTedarikci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTedarikci.Size = new System.Drawing.Size(784, 196);
            this.dataGridViewTedarikci.TabIndex = 6;
            this.dataGridViewTedarikci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTedarikci_CellDoubleClick);
            // 
            // FormDepoMalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 452);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDepoMalzeme";
            this.Text = "FormDepoMalzeme";
            this.Load += new System.EventHandler(this.FormDepoMalzeme_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalzeme)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalzemeKategori)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTedarikci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewDepo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDepoGetir;
        private System.Windows.Forms.TextBox txtDepoAdres;
        private System.Windows.Forms.TextBox txtDepoAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDepoSil;
        private System.Windows.Forms.Button btnDepoGuncelle;
        private System.Windows.Forms.Button btnDepoEkle;
        private System.Windows.Forms.Button btnMalzemeGetir;
        private System.Windows.Forms.DataGridView dataGridViewMalzeme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkboxMalDurum;
        private System.Windows.Forms.TextBox txtMalKatId;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMalzemeSil;
        private System.Windows.Forms.Button btnMalzemeGuncelle;
        private System.Windows.Forms.Button btnMalzemeEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMalTedId;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnMalKategoriGetir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMalKategoriSil;
        private System.Windows.Forms.Button btnMalKategoriGuncelle;
        private System.Windows.Forms.Button btnMalKategoriEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMalKatAdi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridViewMalzemeKategori;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnTedarikciGetir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTedarikciSil;
        private System.Windows.Forms.Button btnTedarikciGuncelle;
        private System.Windows.Forms.Button btnTedarikciEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTedarikciAdi;
        private System.Windows.Forms.DataGridView dataGridViewTedarikci;
        private System.Windows.Forms.TextBox txtDepoArama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMalzemeAdiAra;
        private System.Windows.Forms.Label label9;
    }
}