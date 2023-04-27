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
    public partial class FormKullanıcıGiris : Form
    {
        public FormKullanıcıGiris()
        {
            InitializeComponent();
        }
        Marla_Ado1Entities db = new Marla_Ado1Entities();
        private void FormKullanıcıGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnKullanıcıGiris_Click(object sender, EventArgs e)
        {
            if (txtKullanıcı.Text == "yonetici" && txtSifre.Text == "123456")
            {
                FormDetaylar frm9 = new FormDetaylar();
                frm9.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı ve Şifre giriniz !");
            }
        }
    }
}
