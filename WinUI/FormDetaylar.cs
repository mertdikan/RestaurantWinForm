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
    public partial class FormDetaylar : Form
    {
        public FormDetaylar()
        {
            InitializeComponent();
        }
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        UrunMalzemeDetayRepository umdR = new UrunMalzemeDetayRepository();
        DepoMalzemeDetayRepository dmdR = new DepoMalzemeDetayRepository();
        RestaurantMalzemeDetayRepository resmdR = new RestaurantMalzemeDetayRepository();
        UrunSiparisDetayRepository urunsiparisdR = new UrunSiparisDetayRepository();
        AdisyonSiparisDetayRepository adisyonSDR = new AdisyonSiparisDetayRepository();
        AdisyonOdemeYontemiDetay adisyonOdemeR = new AdisyonOdemeYontemiDetay();
        private void FormDetaylar_Load(object sender, EventArgs e)
        {

        }
        private void btnUMGetir_Click(object sender, EventArgs e)
        {
            UrunMalzemeDetayGetir();

        }

        private void UrunMalzemeDetayGetir()
        {
            dataGridViewUrunMalzemeDetay.DataSource = umdR.GetAll();
            dataGridViewUrunMalzemeDetay.Columns["Malzeme"].Visible = false;
            dataGridViewUrunMalzemeDetay.Columns["Urun"].Visible = false;
        }

        private void btnUMEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUMUrunIdDetay.Text) || string.IsNullOrEmpty(txtUMMalzemeIdDetay.Text) || string.IsNullOrEmpty(txttxtUMMalzemeStokDetay.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyiniz !");
                return;
            }
            umdR.Insert(new UrunMalzemeDetay
            {
                UrunID = Convert.ToInt32(txtUMUrunIdDetay.Text),
                MalzemeID = Convert.ToInt32(txtUMMalzemeIdDetay.Text),
                MalzemeStok = Convert.ToInt32(txttxtUMMalzemeStokDetay.Text)

            });
            UrunMalzemeDetayGetir();
            Temizle_UMDetay();
        }

        private void Temizle_UMDetay()
        {
            txtUMUrunIdDetay.Text = txtUMMalzemeIdDetay.Text = txttxtUMMalzemeStokDetay.Text = string.Empty;
        }
        UrunMalzemeDetay seciliUmDetay;
        private void dataGridViewUrunMalzemeDetay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUrunMalzemeDetay.SelectedRows.Count > 0)
            {
                seciliUmDetay = umdR.GetByID(Convert.ToInt32(dataGridViewUrunMalzemeDetay.SelectedRows[0].Cells[0].Value));
                txtUMUrunIdDetay.Text = Convert.ToString(seciliUmDetay.UrunID);
                txtUMMalzemeIdDetay.Text = Convert.ToString(seciliUmDetay.MalzemeID);
                txttxtUMMalzemeStokDetay.Text = Convert.ToString(seciliUmDetay.MalzemeStok);


            }
        }

        private void btnUMGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUMUrunIdDetay.Text) || string.IsNullOrEmpty(txtUMMalzemeIdDetay.Text) || string.IsNullOrEmpty(txttxtUMMalzemeStokDetay.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliUmDetay.UrunID = Convert.ToInt32(txtUMUrunIdDetay.Text);
                seciliUmDetay.MalzemeID = Convert.ToInt32(txtUMMalzemeIdDetay.Text);
                seciliUmDetay.MalzemeStok = Convert.ToInt32(txttxtUMMalzemeStokDetay.Text);


                umdR.Update(seciliUmDetay);
                UrunMalzemeDetayGetir();
                Temizle_UMDetay();
            }
        }

        private void btnUMSil_Click(object sender, EventArgs e)
        {
            umdR.Delete(Convert.ToInt32(dataGridViewUrunMalzemeDetay.SelectedCells[0].Value));
            UrunMalzemeDetayGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepoMalzemeDetayGetir();
        }

        private void DepoMalzemeDetayGetir()
        {
            dataGridViewDepoMalzemeDetay.DataSource = dmdR.GetAll();
            dataGridViewDepoMalzemeDetay.Columns["Depo"].Visible = false;
            dataGridViewDepoMalzemeDetay.Columns["Malzeme"].Visible = false;
        }

        private void btnDMEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDMDepoId.Text) || string.IsNullOrEmpty(txtDMMalzemeId.Text) || string.IsNullOrEmpty(txtDMDepoStok.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyiniz !");
                return;
            }
            dmdR.Insert(new DepoMalzemeDetay
            {
                DepoID = Convert.ToInt32(txtDMDepoId.Text),
                MalzemeID = Convert.ToInt32(txtDMMalzemeId.Text),
                DepoStok = Convert.ToInt32(txtDMDepoStok.Text)

            });
            DepoMalzemeDetayGetir();
            Temizle_DMDetay();
        }

        private void Temizle_DMDetay()
        {
            txtDMDepoId.Text = txtDMMalzemeId.Text = txtDMDepoStok.Text = string.Empty;
        }

        DepoMalzemeDetay seciliDmDetay;
        private void dataGridViewDepoMalzemeDetay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDepoMalzemeDetay.SelectedRows.Count > 0)
            {
                seciliDmDetay = dmdR.GetByID(Convert.ToInt32(dataGridViewDepoMalzemeDetay.SelectedRows[0].Cells[0].Value));
                txtDMDepoId.Text = Convert.ToString(seciliDmDetay.DepoID);
                txtDMMalzemeId.Text = Convert.ToString(seciliDmDetay.MalzemeID);
                txtDMDepoStok.Text = Convert.ToString(seciliDmDetay.DepoStok);


            }

        }

        private void btnDMGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDMDepoId.Text) || string.IsNullOrEmpty(txtDMMalzemeId.Text) || string.IsNullOrEmpty(txtDMDepoStok.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliDmDetay.DepoID = Convert.ToInt32(txtDMDepoId.Text);
                seciliDmDetay.MalzemeID = Convert.ToInt32(txtDMMalzemeId.Text);
                seciliDmDetay.DepoStok = Convert.ToInt32(txtDMDepoStok.Text);


                dmdR.Update(seciliDmDetay);
                DepoMalzemeDetayGetir();
                Temizle_DMDetay();
            }
        }

        private void btnDMSil_Click(object sender, EventArgs e)
        {
            dmdR.Delete(Convert.ToInt32(dataGridViewDepoMalzemeDetay.SelectedCells[0].Value));
            DepoMalzemeDetayGetir();
        }

        // RESTAURANT MALZEME DETAY
        private void btnRestaurantDetayGetir_Click(object sender, EventArgs e)
        {
            RestaurantMalzemeDetayGetir();
        }

        private void RestaurantMalzemeDetayGetir()
        {
            dataGridView1.DataSource = resmdR.GetAll();
            dataGridView1.Columns["Malzeme"].Visible = false;
            dataGridView1.Columns["Restaurant"].Visible = false;
        }

        private void btnResMalDetayEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResMalDetayMalzemeId.Text) || string.IsNullOrEmpty(txtResMalDetayRestaurantId.Text) || string.IsNullOrEmpty(txtResMalDetayRestaurantStok.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyiniz !");
                return;
            }
            resmdR.Insert(new RestaurantMalzemeDetay
            {
                MalzemeID = Convert.ToInt32(txtResMalDetayMalzemeId.Text),
                RestaurantId = Convert.ToInt32(txtResMalDetayRestaurantId.Text),
                RestaurantStok = Convert.ToInt32(txtResMalDetayRestaurantStok.Text)

            });
            RestaurantMalzemeDetayGetir();
            Temizle_RMDetay();

        }

        private void Temizle_RMDetay()
        {
            txtResMalDetayMalzemeId.Text = txtResMalDetayRestaurantId.Text = txtResMalDetayRestaurantStok.Text = string.Empty;
        }

        RestaurantMalzemeDetay seciliResMalDetay;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                seciliResMalDetay = resmdR.GetByID(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                txtResMalDetayMalzemeId.Text = Convert.ToString(seciliResMalDetay.MalzemeID);
                txtResMalDetayRestaurantId.Text = Convert.ToString(seciliResMalDetay.RestaurantId);
                txtResMalDetayRestaurantStok.Text = Convert.ToString(seciliResMalDetay.RestaurantStok);

            }
        }

        private void btnResMalDetayGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResMalDetayMalzemeId.Text) || string.IsNullOrEmpty(txtResMalDetayRestaurantId.Text) || string.IsNullOrEmpty(txtResMalDetayRestaurantStok.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliResMalDetay.MalzemeID = Convert.ToInt32(txtResMalDetayMalzemeId.Text);
                seciliResMalDetay.RestaurantId = Convert.ToInt32(txtResMalDetayRestaurantId.Text);
                seciliResMalDetay.RestaurantStok = Convert.ToInt32(txtResMalDetayRestaurantStok.Text);


                resmdR.Update(seciliResMalDetay);
                RestaurantMalzemeDetayGetir();
                Temizle_RMDetay();
            }
        }

        private void btnResMalDetaySil_Click(object sender, EventArgs e)
        {
            resmdR.Delete(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
            RestaurantMalzemeDetayGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Malzeme.Select(m => new
            {
                m.MalzemeID,
                m.MalzemeAdi
            }).ToList();
        }

        private void btnResListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Restaurant.Select(r => new
            {
                r.RestaurantID,
                r.RestaurantAdi,
                r.Adres
            }).ToList();
        }


        // URUN SİPARİS DETAY
        private void button3_Click(object sender, EventArgs e)
        {
            UrunSiparisDetayGetir();
        }

        private void UrunSiparisDetayGetir()
        {
            dataGridViewUrunSiparisDetay.DataSource = urunsiparisdR.GetAll();
            dataGridViewUrunSiparisDetay.Columns["Siparis"].Visible = false;
            dataGridViewUrunSiparisDetay.Columns["Urun"].Visible = false;
        }

        private void btnUrunSiparisEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrunSiparisUrunID.Text) || string.IsNullOrEmpty(txtUrunSiparisSiparisId.Text) || string.IsNullOrEmpty(txtUrunSiparisFiyat.Text)
                || string.IsNullOrEmpty(txtUrunSiparisStokMiktari.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyiniz !");
                return;
            }
            urunsiparisdR.Insert(new UrunSiparisDetay
            {
                UrunID = Convert.ToInt32(txtUrunSiparisUrunID.Text),
                SiparisID = Convert.ToInt32(txtUrunSiparisSiparisId.Text),
                SiparisMiktari = Convert.ToInt32(txtUrunSiparisStokMiktari.Text),
                Fiyat = Convert.ToDecimal(txtUrunSiparisFiyat.Text)

            });
            UrunSiparisDetayGetir();
            TemizleUrunSiparisDetay();

        }

        private void TemizleUrunSiparisDetay()
        {
            txtUrunSiparisUrunID.Text = txtUrunSiparisSiparisId.Text = txtUrunSiparisFiyat.Text = txtUrunSiparisStokMiktari.Text = string.Empty;
        }

        UrunSiparisDetay seciliUrunSiparisDetay;
        private void dataGridViewUrunSiparisDetay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUrunSiparisDetay.SelectedRows.Count > 0)
            {
                seciliUrunSiparisDetay = urunsiparisdR.GetByID(Convert.ToInt32(dataGridViewUrunSiparisDetay.CurrentRow.Cells[0].Value));
                txtUrunSiparisUrunID.Text = Convert.ToString(seciliUrunSiparisDetay.UrunID);
                txtUrunSiparisSiparisId.Text = Convert.ToString(seciliUrunSiparisDetay.SiparisID);
                txtUrunSiparisStokMiktari.Text = Convert.ToString(seciliUrunSiparisDetay.SiparisMiktari);
                txtUrunSiparisFiyat.Text = Convert.ToString(seciliUrunSiparisDetay.Fiyat);

            }
        }

        private void btnUrunSiparisGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrunSiparisUrunID.Text) || string.IsNullOrEmpty(txtUrunSiparisSiparisId.Text) || string.IsNullOrEmpty(txtUrunSiparisStokMiktari.Text) || string.IsNullOrEmpty(txtUrunSiparisFiyat.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliUrunSiparisDetay.UrunID = Convert.ToInt32(txtUrunSiparisUrunID.Text);
                seciliUrunSiparisDetay.SiparisID = Convert.ToInt32(txtUrunSiparisSiparisId.Text);
                seciliUrunSiparisDetay.SiparisMiktari = Convert.ToInt32(txtUrunSiparisStokMiktari.Text);
                seciliUrunSiparisDetay.Fiyat = Convert.ToDecimal(txtUrunSiparisFiyat.Text);


                urunsiparisdR.Update(seciliUrunSiparisDetay);
                UrunSiparisDetayGetir();
                TemizleUrunSiparisDetay();
            }
        }

        private void btnUrunSiparisSil_Click(object sender, EventArgs e)
        {
            urunsiparisdR.Delete(Convert.ToInt32(dataGridViewUrunSiparisDetay.SelectedCells[0].Value));
            UrunSiparisDetayGetir();
            TemizleUrunSiparisDetay();
        }


        //ADİSYON SİPARİS DETAY
        private void btnASDGetir_Click(object sender, EventArgs e)
        {
            AdisyonSiparisDetayGetir();
        }

        private void AdisyonSiparisDetayGetir()
        {
            dataGridViewAdisyonSiparisDetay.DataSource = adisyonSDR.GetAll();
            dataGridViewAdisyonSiparisDetay.Columns["Adisyon"].Visible = false;
            dataGridViewAdisyonSiparisDetay.Columns["Siparis"].Visible = false;
        }

        private void btnAdisyonSiparisDetayEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdisyonSiparisDetaySiparisId.Text) || string.IsNullOrEmpty(txtAdisyonSiparisDetayAdisyonID.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyiniz !");
                return;
            }
            adisyonSDR.Insert(new AdisyonSiparisDetay
            {

                SiparisID = Convert.ToInt32(txtAdisyonSiparisDetaySiparisId.Text),
                AdisyonID = Convert.ToInt32(txtAdisyonSiparisDetayAdisyonID.Text),


            });
            AdisyonSiparisDetayGetir();
            TemizleAdisyonSiparisDetay();
        }

        private void TemizleAdisyonSiparisDetay()
        {
            txtAdisyonSiparisDetayAdisyonID.Text = txtAdisyonSiparisDetaySiparisId.Text = string.Empty;
        }

        AdisyonSiparisDetay seciliAdisyonSiparisDetay;
        private void dataGridViewAdisyonSiparisDetay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >0 )
            {
                seciliAdisyonSiparisDetay = adisyonSDR.GetByID(Convert.ToInt32(dataGridViewAdisyonSiparisDetay.SelectedRows[0].Cells[0].Value));
                txtAdisyonSiparisDetaySiparisId.Text = Convert.ToString(seciliAdisyonSiparisDetay.SiparisID);
                txtAdisyonSiparisDetayAdisyonID.Text = Convert.ToString(seciliAdisyonSiparisDetay.AdisyonID);
            }
        }
        private void btnAdisyonSiparisDetayGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrunSiparisUrunID.Text) || string.IsNullOrEmpty(txtUrunSiparisSiparisId.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliAdisyonSiparisDetay.SiparisID = Convert.ToInt32(txtAdisyonSiparisDetaySiparisId.Text);
                seciliAdisyonSiparisDetay.AdisyonID = Convert.ToInt32(txtAdisyonSiparisDetayAdisyonID.Text);
               

                adisyonSDR.Update(seciliAdisyonSiparisDetay);
                AdisyonSiparisDetayGetir();
                TemizleAdisyonSiparisDetay();
            }
        }

        private void btnAdisyonSiparisDetaySil_Click(object sender, EventArgs e)
        {
            adisyonSDR.Delete(Convert.ToInt32(dataGridViewAdisyonSiparisDetay.SelectedCells[0].Value));
            AdisyonSiparisDetayGetir();
            TemizleAdisyonSiparisDetay();
        }

        private void btnAdsyonGetir_Click(object sender, EventArgs e)
        {
            dataGridViewAdisyonSiparisDetay.DataSource = db.Adisyon.Select(a =>
            new
            {
                a.AdisyonID,
                a.AdisyonOdemeDetay

            }).ToList();
        }

        private void btnSparisGetir_Click(object sender, EventArgs e)
        {
            dataGridViewAdisyonSiparisDetay.DataSource = db.Siparis.Select(s =>
            new
            {
               s.SiparisID,
               s.Musteri.Adi,
               s.Musteri.Soyadi

            }).ToList();
        }

        private void btnAdisyonOdemeDetayGetir_Click(object sender, EventArgs e)
        {
            AdisyonOdemeDetayGetir();
        }

        private void AdisyonOdemeDetayGetir()
        {
            dataGridViewAdisyonOdemeDetay.DataSource = adisyonOdemeR.GetAll();
            dataGridViewAdisyonOdemeDetay.Columns["Adisyon"].Visible = false;
            dataGridViewAdisyonOdemeDetay.Columns["OdemeYontemi"].Visible = false;
        }

        private void btnAdisyonOdemeDetayEKLE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdisyonOdemeDetayAdisyonId.Text) || string.IsNullOrEmpty(txtAdisyonOdemeDetayOdemeYontemiId.Text) || string.IsNullOrEmpty(txtAdisyonOdemeDetayOdemeYontemiAdi.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyiniz !");
                return;
            }
            adisyonOdemeR.Insert(new AdisyonOdemeDetay
            {
                AdisyonID = Convert.ToInt32(txtAdisyonOdemeDetayAdisyonId.Text),
                OdemeYontemiID = Convert.ToInt32(txtAdisyonOdemeDetayOdemeYontemiId.Text),
                OdemeYontemiAdi = txtAdisyonOdemeDetayOdemeYontemiAdi.Text
            });
            AdisyonOdemeDetayGetir();
            TemizleAdisyonOdemeDetay();
        }

        private void TemizleAdisyonOdemeDetay()
        {
            txtAdisyonOdemeDetayAdisyonId.Text = txtAdisyonOdemeDetayOdemeYontemiId.Text = txtAdisyonOdemeDetayOdemeYontemiAdi.Text = string.Empty;
        }
        AdisyonOdemeDetay seciliAdisyonOdemeYontemi;
        private void dataGridViewAdisyonOdemeDetay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAdisyonOdemeDetay.SelectedRows.Count > 0)
            {
                seciliAdisyonOdemeYontemi = adisyonOdemeR.GetByID(Convert.ToInt32(dataGridViewAdisyonOdemeDetay.SelectedRows[0].Cells[0].Value));
                txtAdisyonOdemeDetayAdisyonId.Text = Convert.ToString(seciliAdisyonOdemeYontemi.AdisyonID);
                txtAdisyonOdemeDetayOdemeYontemiId.Text = Convert.ToString(seciliAdisyonOdemeYontemi.OdemeYontemiID);
                txtAdisyonOdemeDetayOdemeYontemiAdi.Text = Convert.ToString(seciliAdisyonOdemeYontemi.OdemeYontemiAdi);
            }
        }

        private void btnAdisyonOdemeDetayGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdisyonOdemeDetayAdisyonId.Text) || string.IsNullOrEmpty(txtAdisyonOdemeDetayOdemeYontemiId.Text) || string.IsNullOrEmpty(txtAdisyonOdemeDetayOdemeYontemiAdi.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliAdisyonOdemeYontemi.AdisyonID = Convert.ToInt32(txtAdisyonOdemeDetayAdisyonId.Text);
                seciliAdisyonOdemeYontemi.OdemeYontemiID = Convert.ToInt32(txtAdisyonOdemeDetayOdemeYontemiId.Text);
                seciliAdisyonOdemeYontemi.OdemeYontemiAdi = txtAdisyonOdemeDetayOdemeYontemiAdi.Text;


                adisyonOdemeR.Update(seciliAdisyonOdemeYontemi);
                AdisyonOdemeDetayGetir();
                TemizleAdisyonOdemeDetay();
            }
        }

        private void btnAdisyonOdemeDetaySil_Click(object sender, EventArgs e)
        {
            adisyonOdemeR.Delete(Convert.ToInt32(dataGridViewAdisyonOdemeDetay.SelectedCells[0].Value));
            AdisyonOdemeDetayGetir();
            TemizleAdisyonOdemeDetay();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
