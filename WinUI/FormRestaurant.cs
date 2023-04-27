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
    public partial class FormRestaurant : Form
    {
        public FormRestaurant()
        {
            InitializeComponent();
        }
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        RestaurantRepository resR = new RestaurantRepository();
        private void FormRestaurant_Load(object sender, EventArgs e)
        {

        }

        private void btnRestaurantGetir_Click(object sender, EventArgs e)
        {
            RestaurantGetir();
        }

        private void RestaurantGetir()
        {
            dataGridViewRestaurant.DataSource = resR.GetAll();
            dataGridViewRestaurant.Columns["Calisan"].Visible = false;
            dataGridViewRestaurant.Columns["Menu"].Visible = false;
            dataGridViewRestaurant.Columns["RestaurantMalzemeDetay"].Visible = false;
        }

        private void btnRestaurantEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRestaurantAdi.Text) || string.IsNullOrEmpty(txtRestaurantSehir.Text) || string.IsNullOrEmpty(txtRestaurantAdres.Text) || string.IsNullOrEmpty(txtRestaurantTel.Text) || string.IsNullOrEmpty(txtRestaurantMenuId.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyiniz !");
                return;
            }
            resR.Insert(new Restaurant
            {
                RestaurantAdi = txtRestaurantAdi.Text,
                Sehir = txtRestaurantSehir.Text,
                Adres = txtRestaurantAdres.Text,
                Tel = txtRestaurantTel.Text,
                MenuID =Convert.ToInt32(txtRestaurantMenuId.Text)

            });
            RestaurantGetir();

            TemizleRestaurant();
        }

        private void TemizleRestaurant()
        {
            txtRestaurantAdi.Text = txtRestaurantAdres.Text = txtRestaurantMenuId.Text = txtRestaurantSehir.Text = txtRestaurantTel.Text = string.Empty;
        }
        Restaurant seciliRestaurant;
        private void dataGridViewRestaurant_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRestaurant.SelectedRows.Count > 0)
            {
                seciliRestaurant = resR.GetByID(Convert.ToInt32(dataGridViewRestaurant.SelectedRows[0].Cells[0].Value));
                txtRestaurantAdi.Text = seciliRestaurant.RestaurantAdi;
                txtRestaurantSehir.Text = seciliRestaurant.Sehir;
                txtRestaurantAdres.Text = seciliRestaurant.Adres;
                txtRestaurantTel.Text = seciliRestaurant.Tel;
                txtRestaurantMenuId.Text = Convert.ToString(seciliRestaurant.MenuID);

            }
        }

        private void btnRestaurantGuncele_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRestaurantAdi.Text) || string.IsNullOrEmpty(txtRestaurantSehir.Text) || string.IsNullOrEmpty(txtRestaurantAdres.Text) || string.IsNullOrEmpty(txtRestaurantTel.Text) || string.IsNullOrEmpty(txtRestaurantMenuId.Text))
            {
                MessageBox.Show("Lütfen boş geçmeyin !");
            }
            else
            {
                seciliRestaurant.RestaurantAdi = txtRestaurantAdi.Text;
                seciliRestaurant.Sehir = txtRestaurantSehir.Text;
                seciliRestaurant.Adres = txtRestaurantAdres.Text;
                seciliRestaurant.Tel = txtRestaurantTel.Text;
                seciliRestaurant.MenuID = Convert.ToInt32(txtRestaurantMenuId.Text);

                resR.Update(seciliRestaurant);
                RestaurantGetir();
                TemizleRestaurant();
            }
        }

        private void btnRestaurantSil_Click(object sender, EventArgs e)
        {
            resR.Delete(Convert.ToInt32(dataGridViewRestaurant.SelectedCells[0].Value));
            RestaurantGetir();
        }

       
    }
}
