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
    public partial class FormAdisyonOdeme : Form
    {
        public FormAdisyonOdeme()
        {
            InitializeComponent();
        }
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        AdisyonRepository adR = new AdisyonRepository();
        OdemeYontemiRepository odemeyontR = new OdemeYontemiRepository();
        private void FormAdisyonOdeme_Load(object sender, EventArgs e)
        {

        }

        private void btnAdisyonGetir_Click(object sender, EventArgs e)
        {
            AdisyonGetir();
        }

        private void AdisyonGetir()
        {
            dataGridViewAdisyon.DataSource = adR.GetAll();
            dataGridViewAdisyon.Columns["AdisyonOdemeDetay"].Visible = false;
            dataGridViewAdisyon.Columns["AdisyonSiparisDetay"].Visible = false;
        }

        private void btnAdisyonEkle_Click(object sender, EventArgs e)
        {
            
            adR.Insert(new Adisyon
            {
                Tarih = dateTimePicker1.Value

            });
            AdisyonGetir();

            
        }
        Adisyon seciliAdisyon;
        private void dataGridViewAdisyon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAdisyon.SelectedRows.Count > 0)
            {
                seciliAdisyon = adR.GetByID(Convert.ToInt32(dataGridViewAdisyon.SelectedRows[0].Cells[0].Value));
                dateTimePicker1.Value = seciliAdisyon.Tarih;
  
            }
        }

        private void btnAdisyonGuncelle_Click(object sender, EventArgs e)
        {
            seciliAdisyon.Tarih = dateTimePicker1.Value;
            adR.Update(seciliAdisyon);
            AdisyonGetir();  
        }

        private void btnAdisyonSil_Click(object sender, EventArgs e)
        {
            adR.Delete(Convert.ToInt32(dataGridViewAdisyon.SelectedCells[0].Value));
            AdisyonGetir();
        }

        private void btnOdemeYontGetir_Click(object sender, EventArgs e)
        {
            OdemeYontemiGetir();
        }

        private void OdemeYontemiGetir()
        {
            dataGridViewOdeme.DataSource = odemeyontR.GetAll();
            dataGridViewOdeme.Columns["AdisyonOdemeDetay"].Visible = false;
        }

        private void btnOdemeYontEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOdemeYontemiAdi.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyiniz !");
                return;
            }
            odemeyontR.Insert(new OdemeYontemi
            {
                OdemeYontemiAdi = txtOdemeYontemiAdi.Text,
                

            });
            OdemeYontemiGetir();

            TemizleOdemeYontemi();
        }

        private void TemizleOdemeYontemi()
        {
            txtOdemeYontemiAdi.Text = string.Empty;
        }

        OdemeYontemi seciliOdemeYontemi;
        private void dataGridViewOdeme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOdeme.SelectedRows.Count > 0)
            {
                seciliOdemeYontemi = odemeyontR.GetByID(Convert.ToInt32(dataGridViewOdeme.SelectedRows[0].Cells[0].Value));
                txtOdemeYontemiAdi.Text = seciliOdemeYontemi.OdemeYontemiAdi;        
            }
        }

        private void btnOdemeYontGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOdemeYontemiAdi.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliOdemeYontemi.OdemeYontemiAdi = txtOdemeYontemiAdi.Text;
               

                odemeyontR.Update(seciliOdemeYontemi);
                OdemeYontemiGetir();
                TemizleOdemeYontemi();
            }
        }

        private void btnOdemeYontSil_Click(object sender, EventArgs e)
        {
            odemeyontR.Delete(Convert.ToInt32(dataGridViewOdeme.SelectedCells[0].Value));
            OdemeYontemiGetir();
        }

        private void txtAdisyonArama_TextChanged(object sender, EventArgs e)
        {
            string arananText = txtAdisyonArama.Text.ToLower();
            if (arananText != "")
            {
                dataGridViewAdisyon.DataSource = adR.GetAll().Where(a => a.AdisyonID.ToString().Contains(arananText)).ToList();
            }
            else
            {
                AdisyonGetir();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string arananText = textBox1.Text.ToLower();
            if (arananText != "")
            {
                dataGridViewOdeme.DataSource = odemeyontR.GetAll().Where(o => o.OdemeYontemiAdi.ToLower().Contains(arananText)).ToList();
            }
            else
            {
                OdemeYontemiGetir();
            }
        }
    }
}
