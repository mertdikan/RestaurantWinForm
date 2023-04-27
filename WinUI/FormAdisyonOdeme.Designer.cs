
namespace WinUI
{
    partial class FormAdisyonOdeme
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
            this.btnAdisyonGetir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdisyonArama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdisyonSil = new System.Windows.Forms.Button();
            this.btnAdisyonGuncelle = new System.Windows.Forms.Button();
            this.btnAdisyonEkle = new System.Windows.Forms.Button();
            this.dataGridViewAdisyon = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOdemeYontGetir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOdemeYontemiAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdemeYontSil = new System.Windows.Forms.Button();
            this.btnOdemeYontGuncelle = new System.Windows.Forms.Button();
            this.btnOdemeYontEkle = new System.Windows.Forms.Button();
            this.dataGridViewOdeme = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdisyon)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdeme)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage1.Controls.Add(this.txtAdisyonArama);
            this.tabPage1.Controls.Add(this.btnAdisyonGetir);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridViewAdisyon);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adisyon";
            // 
            // btnAdisyonGetir
            // 
            this.btnAdisyonGetir.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAdisyonGetir.Location = new System.Drawing.Point(748, 359);
            this.btnAdisyonGetir.Name = "btnAdisyonGetir";
            this.btnAdisyonGetir.Size = new System.Drawing.Size(137, 50);
            this.btnAdisyonGetir.TabIndex = 2;
            this.btnAdisyonGetir.Text = "Adisyon Getir";
            this.btnAdisyonGetir.UseVisualStyleBackColor = false;
            this.btnAdisyonGetir.Click += new System.EventHandler(this.btnAdisyonGetir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdisyonSil);
            this.groupBox1.Controls.Add(this.btnAdisyonGuncelle);
            this.groupBox1.Controls.Add(this.btnAdisyonEkle);
            this.groupBox1.Location = new System.Drawing.Point(7, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adisyon";
            // 
            // txtAdisyonArama
            // 
            this.txtAdisyonArama.Location = new System.Drawing.Point(748, 251);
            this.txtAdisyonArama.Name = "txtAdisyonArama";
            this.txtAdisyonArama.Size = new System.Drawing.Size(137, 20);
            this.txtAdisyonArama.TabIndex = 5;
            this.txtAdisyonArama.TextChanged += new System.EventHandler(this.txtAdisyonArama_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adisyon Arama";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tarih";
            // 
            // btnAdisyonSil
            // 
            this.btnAdisyonSil.BackColor = System.Drawing.Color.LightCoral;
            this.btnAdisyonSil.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdisyonSil.Location = new System.Drawing.Point(241, 136);
            this.btnAdisyonSil.Name = "btnAdisyonSil";
            this.btnAdisyonSil.Size = new System.Drawing.Size(98, 50);
            this.btnAdisyonSil.TabIndex = 2;
            this.btnAdisyonSil.Text = "SİL";
            this.btnAdisyonSil.UseVisualStyleBackColor = false;
            this.btnAdisyonSil.Click += new System.EventHandler(this.btnAdisyonSil_Click);
            // 
            // btnAdisyonGuncelle
            // 
            this.btnAdisyonGuncelle.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAdisyonGuncelle.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdisyonGuncelle.Location = new System.Drawing.Point(124, 136);
            this.btnAdisyonGuncelle.Name = "btnAdisyonGuncelle";
            this.btnAdisyonGuncelle.Size = new System.Drawing.Size(96, 50);
            this.btnAdisyonGuncelle.TabIndex = 1;
            this.btnAdisyonGuncelle.Text = "GÜNCELLE";
            this.btnAdisyonGuncelle.UseVisualStyleBackColor = false;
            this.btnAdisyonGuncelle.Click += new System.EventHandler(this.btnAdisyonGuncelle_Click);
            // 
            // btnAdisyonEkle
            // 
            this.btnAdisyonEkle.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdisyonEkle.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdisyonEkle.Location = new System.Drawing.Point(15, 136);
            this.btnAdisyonEkle.Name = "btnAdisyonEkle";
            this.btnAdisyonEkle.Size = new System.Drawing.Size(90, 50);
            this.btnAdisyonEkle.TabIndex = 0;
            this.btnAdisyonEkle.Text = "EKLE";
            this.btnAdisyonEkle.UseVisualStyleBackColor = false;
            this.btnAdisyonEkle.Click += new System.EventHandler(this.btnAdisyonEkle_Click);
            // 
            // dataGridViewAdisyon
            // 
            this.dataGridViewAdisyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdisyon.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewAdisyon.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewAdisyon.Name = "dataGridViewAdisyon";
            this.dataGridViewAdisyon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdisyon.Size = new System.Drawing.Size(894, 210);
            this.dataGridViewAdisyon.TabIndex = 0;
            this.dataGridViewAdisyon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdisyon_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnOdemeYontGetir);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridViewOdeme);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ödeme Yöntemi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnOdemeYontGetir
            // 
            this.btnOdemeYontGetir.Location = new System.Drawing.Point(698, 392);
            this.btnOdemeYontGetir.Name = "btnOdemeYontGetir";
            this.btnOdemeYontGetir.Size = new System.Drawing.Size(203, 40);
            this.btnOdemeYontGetir.TabIndex = 5;
            this.btnOdemeYontGetir.Text = "Ödeme Yöntemi Getir";
            this.btnOdemeYontGetir.UseVisualStyleBackColor = true;
            this.btnOdemeYontGetir.Click += new System.EventHandler(this.btnOdemeYontGetir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOdemeYontemiAdi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnOdemeYontSil);
            this.groupBox2.Controls.Add(this.btnOdemeYontGuncelle);
            this.groupBox2.Controls.Add(this.btnOdemeYontEkle);
            this.groupBox2.Location = new System.Drawing.Point(10, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 222);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödeme Yöntemi";
            // 
            // txtOdemeYontemiAdi
            // 
            this.txtOdemeYontemiAdi.Location = new System.Drawing.Point(161, 50);
            this.txtOdemeYontemiAdi.Name = "txtOdemeYontemiAdi";
            this.txtOdemeYontemiAdi.Size = new System.Drawing.Size(100, 20);
            this.txtOdemeYontemiAdi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ödeme Yöntemi Adı";
            // 
            // btnOdemeYontSil
            // 
            this.btnOdemeYontSil.Location = new System.Drawing.Point(255, 154);
            this.btnOdemeYontSil.Name = "btnOdemeYontSil";
            this.btnOdemeYontSil.Size = new System.Drawing.Size(93, 40);
            this.btnOdemeYontSil.TabIndex = 2;
            this.btnOdemeYontSil.Text = "SİL";
            this.btnOdemeYontSil.UseVisualStyleBackColor = true;
            this.btnOdemeYontSil.Click += new System.EventHandler(this.btnOdemeYontSil_Click);
            // 
            // btnOdemeYontGuncelle
            // 
            this.btnOdemeYontGuncelle.Location = new System.Drawing.Point(128, 154);
            this.btnOdemeYontGuncelle.Name = "btnOdemeYontGuncelle";
            this.btnOdemeYontGuncelle.Size = new System.Drawing.Size(102, 40);
            this.btnOdemeYontGuncelle.TabIndex = 1;
            this.btnOdemeYontGuncelle.Text = "GUNCELLE";
            this.btnOdemeYontGuncelle.UseVisualStyleBackColor = true;
            this.btnOdemeYontGuncelle.Click += new System.EventHandler(this.btnOdemeYontGuncelle_Click);
            // 
            // btnOdemeYontEkle
            // 
            this.btnOdemeYontEkle.Location = new System.Drawing.Point(15, 154);
            this.btnOdemeYontEkle.Name = "btnOdemeYontEkle";
            this.btnOdemeYontEkle.Size = new System.Drawing.Size(86, 40);
            this.btnOdemeYontEkle.TabIndex = 0;
            this.btnOdemeYontEkle.Text = "EKLE";
            this.btnOdemeYontEkle.UseVisualStyleBackColor = true;
            this.btnOdemeYontEkle.Click += new System.EventHandler(this.btnOdemeYontEkle_Click);
            // 
            // dataGridViewOdeme
            // 
            this.dataGridViewOdeme.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdeme.Location = new System.Drawing.Point(10, 6);
            this.dataGridViewOdeme.Name = "dataGridViewOdeme";
            this.dataGridViewOdeme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOdeme.Size = new System.Drawing.Size(891, 190);
            this.dataGridViewOdeme.TabIndex = 3;
            this.dataGridViewOdeme.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOdeme_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(746, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ödeme Yöntemi Arama";
            // 
            // FormAdisyonOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 512);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdisyonOdeme";
            this.Text = "FormAdisyonOdeme";
            this.Load += new System.EventHandler(this.FormAdisyonOdeme_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdisyon)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdeme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewAdisyon;
        private System.Windows.Forms.Button btnAdisyonGetir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdisyonSil;
        private System.Windows.Forms.Button btnAdisyonGuncelle;
        private System.Windows.Forms.Button btnAdisyonEkle;
        private System.Windows.Forms.Button btnOdemeYontGetir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOdemeYontemiAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdemeYontSil;
        private System.Windows.Forms.Button btnOdemeYontGuncelle;
        private System.Windows.Forms.Button btnOdemeYontEkle;
        private System.Windows.Forms.DataGridView dataGridViewOdeme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdisyonArama;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}