
namespace WinUI
{
    partial class FormRestaurant
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
            this.btnRestaurantGetir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRestaurantMenuId = new System.Windows.Forms.TextBox();
            this.txtRestaurantTel = new System.Windows.Forms.TextBox();
            this.txtRestaurantAdres = new System.Windows.Forms.TextBox();
            this.txtRestaurantSehir = new System.Windows.Forms.TextBox();
            this.txtRestaurantAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestaurantSil = new System.Windows.Forms.Button();
            this.btnRestaurantGuncele = new System.Windows.Forms.Button();
            this.btnRestaurantEkle = new System.Windows.Forms.Button();
            this.dataGridViewRestaurant = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurant)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(838, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRestaurantGetir);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridViewRestaurant);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(830, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Restaurant";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRestaurantGetir
            // 
            this.btnRestaurantGetir.Location = new System.Drawing.Point(694, 229);
            this.btnRestaurantGetir.Name = "btnRestaurantGetir";
            this.btnRestaurantGetir.Size = new System.Drawing.Size(126, 34);
            this.btnRestaurantGetir.TabIndex = 2;
            this.btnRestaurantGetir.Text = "Restaurant Getir";
            this.btnRestaurantGetir.UseVisualStyleBackColor = true;
            this.btnRestaurantGetir.Click += new System.EventHandler(this.btnRestaurantGetir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRestaurantMenuId);
            this.groupBox1.Controls.Add(this.txtRestaurantTel);
            this.groupBox1.Controls.Add(this.txtRestaurantAdres);
            this.groupBox1.Controls.Add(this.txtRestaurantSehir);
            this.groupBox1.Controls.Add(this.txtRestaurantAdi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRestaurantSil);
            this.groupBox1.Controls.Add(this.btnRestaurantGuncele);
            this.groupBox1.Controls.Add(this.btnRestaurantEkle);
            this.groupBox1.Location = new System.Drawing.Point(29, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restaurant";
            // 
            // txtRestaurantMenuId
            // 
            this.txtRestaurantMenuId.Location = new System.Drawing.Point(147, 148);
            this.txtRestaurantMenuId.Name = "txtRestaurantMenuId";
            this.txtRestaurantMenuId.Size = new System.Drawing.Size(126, 20);
            this.txtRestaurantMenuId.TabIndex = 15;
            // 
            // txtRestaurantTel
            // 
            this.txtRestaurantTel.Location = new System.Drawing.Point(147, 122);
            this.txtRestaurantTel.Name = "txtRestaurantTel";
            this.txtRestaurantTel.Size = new System.Drawing.Size(126, 20);
            this.txtRestaurantTel.TabIndex = 14;
            // 
            // txtRestaurantAdres
            // 
            this.txtRestaurantAdres.Location = new System.Drawing.Point(147, 93);
            this.txtRestaurantAdres.Name = "txtRestaurantAdres";
            this.txtRestaurantAdres.Size = new System.Drawing.Size(126, 20);
            this.txtRestaurantAdres.TabIndex = 13;
            // 
            // txtRestaurantSehir
            // 
            this.txtRestaurantSehir.Location = new System.Drawing.Point(147, 62);
            this.txtRestaurantSehir.Name = "txtRestaurantSehir";
            this.txtRestaurantSehir.Size = new System.Drawing.Size(126, 20);
            this.txtRestaurantSehir.TabIndex = 12;
            // 
            // txtRestaurantAdi
            // 
            this.txtRestaurantAdi.Location = new System.Drawing.Point(147, 31);
            this.txtRestaurantAdi.Name = "txtRestaurantAdi";
            this.txtRestaurantAdi.Size = new System.Drawing.Size(126, 20);
            this.txtRestaurantAdi.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "MenuId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sehir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Restaurant Adı";
            // 
            // btnRestaurantSil
            // 
            this.btnRestaurantSil.Location = new System.Drawing.Point(199, 193);
            this.btnRestaurantSil.Name = "btnRestaurantSil";
            this.btnRestaurantSil.Size = new System.Drawing.Size(75, 23);
            this.btnRestaurantSil.TabIndex = 5;
            this.btnRestaurantSil.Text = "SİL";
            this.btnRestaurantSil.UseVisualStyleBackColor = true;
            this.btnRestaurantSil.Click += new System.EventHandler(this.btnRestaurantSil_Click);
            // 
            // btnRestaurantGuncele
            // 
            this.btnRestaurantGuncele.Location = new System.Drawing.Point(107, 193);
            this.btnRestaurantGuncele.Name = "btnRestaurantGuncele";
            this.btnRestaurantGuncele.Size = new System.Drawing.Size(86, 23);
            this.btnRestaurantGuncele.TabIndex = 4;
            this.btnRestaurantGuncele.Text = "GUNCELLE";
            this.btnRestaurantGuncele.UseVisualStyleBackColor = true;
            this.btnRestaurantGuncele.Click += new System.EventHandler(this.btnRestaurantGuncele_Click);
            // 
            // btnRestaurantEkle
            // 
            this.btnRestaurantEkle.Location = new System.Drawing.Point(6, 193);
            this.btnRestaurantEkle.Name = "btnRestaurantEkle";
            this.btnRestaurantEkle.Size = new System.Drawing.Size(75, 23);
            this.btnRestaurantEkle.TabIndex = 3;
            this.btnRestaurantEkle.Text = "EKLE";
            this.btnRestaurantEkle.UseVisualStyleBackColor = true;
            this.btnRestaurantEkle.Click += new System.EventHandler(this.btnRestaurantEkle_Click);
            // 
            // dataGridViewRestaurant
            // 
            this.dataGridViewRestaurant.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRestaurant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestaurant.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewRestaurant.Name = "dataGridViewRestaurant";
            this.dataGridViewRestaurant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRestaurant.Size = new System.Drawing.Size(818, 199);
            this.dataGridViewRestaurant.TabIndex = 0;
            this.dataGridViewRestaurant.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRestaurant_CellDoubleClick);
            // 
            // FormRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 499);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormRestaurant";
            this.Text = "FormRestaurant";
            this.Load += new System.EventHandler(this.FormRestaurant_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewRestaurant;
        private System.Windows.Forms.Button btnRestaurantGetir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestaurantSil;
        private System.Windows.Forms.Button btnRestaurantGuncele;
        private System.Windows.Forms.Button btnRestaurantEkle;
        private System.Windows.Forms.TextBox txtRestaurantMenuId;
        private System.Windows.Forms.TextBox txtRestaurantTel;
        private System.Windows.Forms.TextBox txtRestaurantAdres;
        private System.Windows.Forms.TextBox txtRestaurantSehir;
        private System.Windows.Forms.TextBox txtRestaurantAdi;
    }
}