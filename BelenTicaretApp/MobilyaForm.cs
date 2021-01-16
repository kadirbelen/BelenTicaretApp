using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelenTicaretApp
{
    public partial class MobilyaForm : Form
    {
        public MobilyaForm()
        {
            InitializeComponent();
        }
        MobilyaDal mobilyaDal = new MobilyaDal();
        public void  LoadMobilya()
        {
            dgwMobilya.DataSource = mobilyaDal.GetAll().ToList();
        }
        private void btnMobilyaEkleme_Click(object sender, EventArgs e)
        {
            mobilyaDal.Add(new Mobilya
            {
                Urunler = txtMobilyaUrun.Text,
                Fiyat = Convert.ToInt32(txtMobilyaFiyat.Text),
                Miktar = Convert.ToInt32(txtMobilyaMiktar.Text)
            });
            MessageBox.Show("Eklendi");
            LoadMobilya();
        }

        private void MobilyaForm_Load(object sender, EventArgs e)
        {
            LoadMobilya();
        }

        private void btnMobilyaUpdate_Click(object sender, EventArgs e)
        {
            mobilyaDal.Update(new Mobilya
            {
                Id = Convert.ToInt32(dgwMobilya.CurrentRow.Cells[0].Value),
                Urunler = txtMobilyaUrunUpdate.Text,
                Fiyat = Convert.ToInt32(txtMobilyaFiyatUpdate.Text),
                Miktar = Convert.ToInt32(txtMobilyaMiktarUpdate.Text)
            });
            MessageBox.Show("Güncellendi");
            LoadMobilya();
        }

        private void dgwMobilya_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMobilyaUrunUpdate.Text = dgwMobilya.CurrentRow.Cells[1].Value.ToString();
            txtMobilyaFiyatUpdate.Text = dgwMobilya.CurrentRow.Cells[2].Value.ToString();
            txtMobilyaMiktarUpdate.Text = dgwMobilya.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnMobilyaTemizle_Click(object sender, EventArgs e)
        {
            txtMobilyaUrun.Clear();
            txtMobilyaFiyat.Clear();
            txtMobilyaMiktar.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMobilyaUrunUpdate.Clear();
            txtMobilyaMiktarUpdate.Clear();
            txtMobilyaFiyatUpdate.Clear();
        }

        private void btnGeriMobilya_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
