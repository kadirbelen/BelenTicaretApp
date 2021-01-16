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
    public partial class BekoForm : Form
    {
        public BekoForm()
        {
            InitializeComponent();
        }
        BekoDal bekoDal = new BekoDal();

        private void BekoForm_Load(object sender, EventArgs e)
        {

            LoadBeko();
        }
        public void LoadBeko()
        {
            dataGridView1.DataSource = bekoDal.GetAll();
        }
        
        private void btnBekoEkleme_Click(object sender, EventArgs e)
        {
            
            bekoDal.Add(new Beko { 

                Urunler = txtBekoUrun.Text,
                Fiyat = Convert.ToInt32(txtBekoFiyat.Text),
                Miktar=Convert.ToInt32(txtBekoMiktar.Text)

            });
            MessageBox.Show("eklendi");
            LoadBeko();
        }

        private void btnBekoUpdate_Click(object sender, EventArgs e)
        {
            bekoDal.Update(new Beko
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Urunler = txtBekoUrunUpdate.Text,
                Fiyat = Convert.ToInt32(txtBekoFiyatUpdate.Text),
                Miktar = Convert.ToInt32(txtBekoMiktarUpdate.Text)
            });
            MessageBox.Show("Güncellendi");
            LoadBeko();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBekoUrunUpdate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBekoFiyatUpdate.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBekoMiktarUpdate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBekoFiyatUpdate.Clear();
            txtBekoUrunUpdate.Clear();
            txtBekoMiktarUpdate.Clear();
        }

        private void btnClearBeko_Click(object sender, EventArgs e)
        {
            txtBekoFiyat.Clear();
            txtBekoUrun.Clear();
            txtBekoMiktar.Clear();
        }

        private void btnGeriBeko_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
