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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        MenuRepository menuR = new MenuRepository();

        private void FormMenu_Load(object sender, EventArgs e)
        {
            var kat = db.MenuKategori.ToList();
            comboBox1.DataSource = kat;
            comboBox1.DisplayMember = "MenuKategoriAdi";
            comboBox1.ValueMember = "MenuKategoriID";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.Urun.Where(k => k.KategoriID == (int)comboBox1.SelectedValue).Select(k => new
            {
                UrunAdi = k.UrunAdi,
                Aciklama = k.UrunAciklamasi,
                Fiyat = k.Fiyat


            }).ToList();
        }

  
    }
}
