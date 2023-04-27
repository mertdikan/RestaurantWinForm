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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCalisan frm1 = new FormCalisan();
            frm1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMenu frm2 = new FormMenu();
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUrunKategori frm3 = new FormUrunKategori();
            frm3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMusteriSiparis frm4 = new FormMusteriSiparis();
            frm4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormDepoMalzeme frm5 = new FormDepoMalzeme();
            frm5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormRestaurant frm6 = new FormRestaurant();
            frm6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormAdisyonOdeme frm7 = new FormAdisyonOdeme();
            frm7.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormKullanıcıGiris frm8 = new FormKullanıcıGiris();
            frm8.ShowDialog();
        }
    }
}
