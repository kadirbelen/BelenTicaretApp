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
    public partial class GirişForm : Form
    {
        public GirişForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = "Belen Ticaret";
            var sifre = "belen12345";

            if (txtKullanici.Text==kullaniciAdi &&txtSifre.Text==sifre)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifre veya Kullanıcı adı hatalı tekrar deneyiniz!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
