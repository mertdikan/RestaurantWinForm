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
    public partial class FormUrunKategori : Form
    {
        public FormUrunKategori()
        {
            InitializeComponent();
        }

        Marla_Ado1Entities db = new Marla_Ado1Entities();
        KategoriRepository katR = new KategoriRepository();
        UrunRepository urunR = new UrunRepository();
        private void FormUrunKategori_Load(object sender, EventArgs e)
        {

        }

        private void btnEkleKat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKagetoriAdi.Text) || string.IsNullOrEmpty(txtMenuId.Text))
            {
                MessageBox.Show("Kategori Adini ve menü id'yi boş geçmeyiniz");
                return;
            }
            katR.Insert(new MenuKategori
            {
                MenuKategoriAdi = txtKagetoriAdi.Text,
                MenuID = Convert.ToInt32(txtMenuId.Text)
            });
            KategoriGetir();
            Temizle2();
        }

        private void Temizle2()
        {
            txtKagetoriAdi.Text = txtMenuId.Text = string.Empty;
        }

        private void Temizle()
        {
            
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        private void KategoriGetir()
        {
            dataGridViewKategori.DataSource = katR.GetAll();
            dataGridViewKategori.Columns["Menu"].Visible = false;
            dataGridViewKategori.Columns["Urun"].Visible = false;
        }

        private void btnGuncelleKat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKagetoriAdi.Text) || string.IsNullOrEmpty(txtMenuId.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliKategori.MenuKategoriAdi = txtKagetoriAdi.Text;
                seciliKategori.MenuID = Convert.ToInt32(txtMenuId.Text);

                katR.Update(seciliKategori);
                KategoriGetir();
                Temizle2();
            }
        }

        MenuKategori seciliKategori;
        private void dataGridViewKategori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewKategori.SelectedRows.Count > 0)
            {
                seciliKategori = katR.GetByID(Convert.ToInt32(dataGridViewKategori.SelectedRows[0].Cells[0].Value));
                txtKagetoriAdi.Text = seciliKategori.MenuKategoriAdi;
                txtMenuId.Text = Convert.ToString(seciliKategori.MenuKategoriID);

            }
        }

        private void btnSilKat_Click(object sender, EventArgs e)
        {
            katR.Delete(Convert.ToInt32(dataGridViewKategori.SelectedCells[0].Value));
            KategoriGetir();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            UrunGetir();
        }

        private void UrunGetir()
        {
            dataGridViewUrun.DataSource = urunR.GetAll();
            dataGridViewUrun.Columns["MenuKategori"].Visible = false;
            dataGridViewUrun.Columns["UrunMalzemeDetay"].Visible = false;
            dataGridViewUrun.Columns["UrunSiparisDetay"].Visible = false;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKategoriId.Text) || string.IsNullOrEmpty(txtUrunAdi.Text) || string.IsNullOrEmpty(txtUrunAciklamasi.Text) || string.IsNullOrEmpty(txtFiyat.Text))
            {
                MessageBox.Show("sizin için de uygunsa boş geçmeyiniz lütfen ");
                return;
            }
            urunR.Insert(new Urun
            {
                KategoriID = Convert.ToInt32(txtKategoriId.Text),
                UrunAdi = txtUrunAdi.Text,
                UrunAciklamasi = txtUrunAciklamasi.Text,
                Fiyat = Convert.ToDecimal(txtFiyat.Text),
                Durum = checkBox1.Checked


            }) ;
            UrunGetir();
            Temizle3();
        }

        private void Temizle3()
        {
            txtKategoriId.Text = txtUrunAdi.Text = txtUrunAciklamasi.Text = txtFiyat.Text = string.Empty;
        }
  
        Urun seciliUrun;
        private void dataGridViewUrun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUrun.SelectedRows.Count > 0)
            {
                seciliUrun = urunR.GetByID(Convert.ToInt32(dataGridViewUrun.SelectedRows[0].Cells[0].Value));
                txtKategoriId.Text = Convert.ToString(seciliUrun.KategoriID);
                txtUrunAdi.Text = seciliUrun.UrunAdi;
                txtUrunAciklamasi.Text = seciliUrun.UrunAciklamasi;
                txtFiyat.Text = Convert.ToString(seciliUrun.Fiyat);
                checkBox1.Checked = Convert.ToBoolean(seciliUrun.Durum);
            }
        }
        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKategoriId.Text) || string.IsNullOrEmpty(txtUrunAdi.Text) || string.IsNullOrEmpty(txtUrunAciklamasi.Text) || string.IsNullOrEmpty(txtFiyat.Text) )
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliUrun.KategoriID = Convert.ToInt32(txtKategoriId.Text);
                seciliUrun.UrunAdi = txtUrunAdi.Text;
                seciliUrun.UrunAciklamasi = txtUrunAciklamasi.Text;
                seciliUrun.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                seciliUrun.Durum = checkBox1.Checked;
                urunR.Update(seciliUrun);
                UrunGetir();
                Temizle3();
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {

            urunR.Delete(Convert.ToInt32(dataGridViewUrun.SelectedCells[0].Value));
            UrunGetir();
        }


    }
}
