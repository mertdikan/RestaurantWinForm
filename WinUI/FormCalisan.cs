using BLL.Repositories;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class FormCalisan : Form
    {
        public FormCalisan()
        {
            InitializeComponent();
        }

        Marla_Ado1Entities db = new Marla_Ado1Entities();
        CalisanRepository calR = new CalisanRepository();
        CalisanDetayRepository calDR = new CalisanDetayRepository();

        private void FormCalisan_Load(object sender, EventArgs e)
        {

        }

       
        private void btnCalisanGetir_Click(object sender, EventArgs e)
        {
            CalisanlariGetir();
        }

        private void CalisanlariGetir()
        {
            dataGridView1.DataSource = calR.GetAll();
            dataGridView1.Columns["Siparis"].Visible = false;
            dataGridView1.Columns["Restaurant"].Visible = false;
            dataGridView1.Columns["CalisanDetay"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("boş geçme");
                return;
            }
            calR.Insert(new Calisan
            {
                CalisanAdi = textBox1.Text,
                CalisanSoyadi = textBox2.Text,
                Unvan = textBox3.Text,
                RestaurantID = Convert.ToInt32(textBox4.Text)
            });
            CalisanlariGetir();
            Temizle();
        }

        private void Temizle()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;
        }

        Calisan seciliCalisan;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                seciliCalisan = calR.GetByID(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                textBox1.Text = seciliCalisan.CalisanAdi;
                textBox2.Text = seciliCalisan.CalisanSoyadi;
                textBox3.Text = seciliCalisan.Unvan;
                textBox4.Text = Convert.ToString(seciliCalisan.RestaurantID);
            }
            
 
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliCalisan.CalisanAdi = textBox1.Text;
                seciliCalisan.CalisanSoyadi = textBox2.Text;
                seciliCalisan.Unvan = textBox3.Text;
                seciliCalisan.RestaurantID = Convert.ToInt32(textBox4.Text);
                calR.Update(seciliCalisan);
                CalisanlariGetir();
                Temizle();
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            calR.Delete(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
            CalisanlariGetir();
        }

        private void btnCalisanDetay_Click(object sender, EventArgs e)
        {
            CalisanDetayGetir();
        }

        private void CalisanDetayGetir()
        {
            dataGridView2.DataSource = calDR.GetAll().Select(cd => new { 
                cd.CalisanDetayID,
                cd.Maas,
                cd.Tckn,
                cd.TelNo,
                cd.Mail

            }).ToList();
       
        }

        private void btnCalisanDetayEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaas.Text) || string.IsNullOrEmpty(txtTckn.Text) || string.IsNullOrEmpty(txtTelNo.Text) || string.IsNullOrEmpty(txtMail.Text))
            {
                MessageBox.Show("boş geçme");
                return;
            }
            calDR.Insert(new CalisanDetay
            {
                CalisanDetayID = Convert.ToInt32(txtCalisanDetayID.Text),
                Maas = Convert.ToDecimal(txtMaas.Text),
                Tckn = txtTckn.Text,
                TelNo = txtTelNo.Text,
                Mail = txtMail.Text
            });
            CalisanDetayGetir();
            Temizle2();
        }

        private void Temizle2()
        {
            txtMaas.Text = txtTckn.Text = txtTelNo.Text = txtMail.Text = string.Empty;
        }

        CalisanDetay seciliCalisanDetay;
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                seciliCalisanDetay = calDR.GetByID(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
                txtCalisanDetayID.Text = Convert.ToString(seciliCalisanDetay.CalisanDetayID);
                txtMaas.Text = Convert.ToString(seciliCalisanDetay.Maas);
                txtTckn.Text = seciliCalisanDetay.Tckn;
                txtTelNo.Text = seciliCalisanDetay.TelNo;
                txtMail.Text = seciliCalisanDetay.Mail;
            }
        }

        private void btnCalisanDetayGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaas.Text) || string.IsNullOrEmpty(txtTckn.Text) || string.IsNullOrEmpty(txtTelNo.Text) || string.IsNullOrEmpty(txtMail.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliCalisanDetay.Maas = Convert.ToDecimal(txtMaas.Text);
                seciliCalisanDetay.Tckn = txtTckn.Text;
                seciliCalisanDetay.TelNo = txtTelNo.Text;
                seciliCalisanDetay.Mail = txtMail.Text;
                calDR.Update(seciliCalisanDetay);
                CalisanDetayGetir();
                Temizle2();
            }
        }

        private void btnCalisanDetaySil_Click(object sender, EventArgs e)
        {
            calDR.Delete(Convert.ToInt32(dataGridView2.SelectedCells[0].Value));
            CalisanDetayGetir();
        }

        private void txtCalisanArama_TextChanged(object sender, EventArgs e)
        {
            string calisanArama = txtCalisanArama.Text.ToLower();
            if (calisanArama != "")
            {
                dataGridView1.DataSource = calR.GetAll().Where(c => c.CalisanAdi.ToLower().Contains(calisanArama)).ToList();
                dataGridView1.Columns["Siparis"].Visible = false;
                dataGridView1.Columns["Restaurant"].Visible = false;
                dataGridView1.Columns["CalisanDetay"].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = calR.GetAll().Select(d => new
                {

                }).ToList();
            }
        }

        private void txtCalisanDetayArama_TextChanged(object sender, EventArgs e)
        {
            string calisanDetayArama = txtCalisanDetayArama.Text.ToLower();
            if (calisanDetayArama != "")
            {
                dataGridView2.DataSource = calDR.GetAll().Where(c => c.CalisanDetayID.ToString().ToLower().Contains(calisanDetayArama)).ToList();
                dataGridView2.Columns["Calisan"].Visible = false;
            }
            else
            {
                CalisanDetayGetir();
            }
        }
    }
}
