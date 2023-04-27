
namespace WinUI
{
    partial class FormCalisan
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
            this.txtCalisanArama = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCalisanGetir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCalisanDetayArama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCalisanDetayID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalisanDetayEkle = new System.Windows.Forms.Button();
            this.btnCalisanDetayGuncelle = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnCalisanDetaySil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTckn = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.btnCalisanDetay = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 513);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCalisanArama);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnCalisanGetir);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(875, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calisan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCalisanArama
            // 
            this.txtCalisanArama.Location = new System.Drawing.Point(693, 245);
            this.txtCalisanArama.Name = "txtCalisanArama";
            this.txtCalisanArama.Size = new System.Drawing.Size(143, 20);
            this.txtCalisanArama.TabIndex = 9;
            this.txtCalisanArama.TextChanged += new System.EventHandler(this.txtCalisanArama_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(576, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Calisan Arama";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(18, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 243);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calisan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Calisan Soyadi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Calisan Adi";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(6, 196);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 27);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(136, 196);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(98, 27);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(147, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(108, 20);
            this.textBox4.TabIndex = 22;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(273, 196);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 27);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Unvan";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(108, 20);
            this.textBox3.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "RestaurantId";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 20);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 19;
            // 
            // btnCalisanGetir
            // 
            this.btnCalisanGetir.Location = new System.Drawing.Point(674, 406);
            this.btnCalisanGetir.Name = "btnCalisanGetir";
            this.btnCalisanGetir.Size = new System.Drawing.Size(153, 43);
            this.btnCalisanGetir.TabIndex = 2;
            this.btnCalisanGetir.Text = "ÇalışanGetir";
            this.btnCalisanGetir.UseVisualStyleBackColor = true;
            this.btnCalisanGetir.Click += new System.EventHandler(this.btnCalisanGetir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(830, 205);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCalisanDetayArama);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnCalisanDetay);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(875, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CalisanDetay";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCalisanDetayArama
            // 
            this.txtCalisanDetayArama.Location = new System.Drawing.Point(701, 229);
            this.txtCalisanDetayArama.Name = "txtCalisanDetayArama";
            this.txtCalisanDetayArama.Size = new System.Drawing.Size(143, 20);
            this.txtCalisanDetayArama.TabIndex = 11;
            this.txtCalisanDetayArama.TextChanged += new System.EventHandler(this.txtCalisanDetayArama_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(545, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Calisan Detay Arama";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCalisanDetayID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnCalisanDetayEkle);
            this.groupBox2.Controls.Add(this.btnCalisanDetayGuncelle);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.btnCalisanDetaySil);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTelNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTckn);
            this.groupBox2.Controls.Add(this.txtMaas);
            this.groupBox2.Location = new System.Drawing.Point(6, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 243);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CalisanDetay";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(17, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Calisan Detay ID";
            // 
            // txtCalisanDetayID
            // 
            this.txtCalisanDetayID.Location = new System.Drawing.Point(231, 32);
            this.txtCalisanDetayID.Name = "txtCalisanDetayID";
            this.txtCalisanDetayID.Size = new System.Drawing.Size(108, 20);
            this.txtCalisanDetayID.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "TCKN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Maas";
            // 
            // btnCalisanDetayEkle
            // 
            this.btnCalisanDetayEkle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanDetayEkle.Location = new System.Drawing.Point(6, 196);
            this.btnCalisanDetayEkle.Name = "btnCalisanDetayEkle";
            this.btnCalisanDetayEkle.Size = new System.Drawing.Size(98, 27);
            this.btnCalisanDetayEkle.TabIndex = 12;
            this.btnCalisanDetayEkle.Text = "Ekle";
            this.btnCalisanDetayEkle.UseVisualStyleBackColor = true;
            this.btnCalisanDetayEkle.Click += new System.EventHandler(this.btnCalisanDetayEkle_Click);
            // 
            // btnCalisanDetayGuncelle
            // 
            this.btnCalisanDetayGuncelle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanDetayGuncelle.Location = new System.Drawing.Point(125, 196);
            this.btnCalisanDetayGuncelle.Name = "btnCalisanDetayGuncelle";
            this.btnCalisanDetayGuncelle.Size = new System.Drawing.Size(98, 27);
            this.btnCalisanDetayGuncelle.TabIndex = 14;
            this.btnCalisanDetayGuncelle.Text = "Güncelle";
            this.btnCalisanDetayGuncelle.UseVisualStyleBackColor = true;
            this.btnCalisanDetayGuncelle.Click += new System.EventHandler(this.btnCalisanDetayGuncelle_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(231, 160);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(108, 20);
            this.txtMail.TabIndex = 22;
            // 
            // btnCalisanDetaySil
            // 
            this.btnCalisanDetaySil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanDetaySil.Location = new System.Drawing.Point(241, 196);
            this.btnCalisanDetaySil.Name = "btnCalisanDetaySil";
            this.btnCalisanDetaySil.Size = new System.Drawing.Size(98, 27);
            this.btnCalisanDetaySil.TabIndex = 13;
            this.btnCalisanDetaySil.Text = "Sil";
            this.btnCalisanDetaySil.UseVisualStyleBackColor = true;
            this.btnCalisanDetaySil.Click += new System.EventHandler(this.btnCalisanDetaySil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(17, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Telefon Numarası";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(231, 130);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(108, 20);
            this.txtTelNo.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(17, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mail";
            // 
            // txtTckn
            // 
            this.txtTckn.Location = new System.Drawing.Point(231, 96);
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(108, 20);
            this.txtTckn.TabIndex = 20;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(231, 65);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(108, 20);
            this.txtMaas.TabIndex = 19;
            // 
            // btnCalisanDetay
            // 
            this.btnCalisanDetay.Location = new System.Drawing.Point(701, 406);
            this.btnCalisanDetay.Name = "btnCalisanDetay";
            this.btnCalisanDetay.Size = new System.Drawing.Size(153, 43);
            this.btnCalisanDetay.TabIndex = 5;
            this.btnCalisanDetay.Text = "ÇalışanDetayGetir";
            this.btnCalisanDetay.UseVisualStyleBackColor = true;
            this.btnCalisanDetay.Click += new System.EventHandler(this.btnCalisanDetay_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(863, 203);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // FormCalisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 546);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormCalisan";
            this.Text = "FormCalisan";
            this.Load += new System.EventHandler(this.FormCalisan_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCalisanGetir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalisanDetayEkle;
        private System.Windows.Forms.Button btnCalisanDetayGuncelle;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnCalisanDetaySil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTckn;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Button btnCalisanDetay;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCalisanDetayID;
        private System.Windows.Forms.TextBox txtCalisanArama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCalisanDetayArama;
        private System.Windows.Forms.Label label11;
    }
}