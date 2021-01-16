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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           BekoForm formBeko = new BekoForm();
            formBeko.Show(); //form2 göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MobilyaForm mobilyaForm = new MobilyaForm();
            mobilyaForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManifaturaForm manifaturaForm = new ManifaturaForm();
            manifaturaForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }
    }
}
