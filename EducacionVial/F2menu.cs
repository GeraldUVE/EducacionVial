using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducacionVial
{
    public partial class F2menu : Form
    {
        public F2menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butonmoto_Click(object sender, EventArgs e)
        {
            F2menu f2moto = F2moto();
            f2moto.Show();
            this.Hide();
        }

        private void butoncarro_Click(object sender, EventArgs e)
        {
            F2menu f2menu = new F2Carro();
            femenu.show(f2menu);
            this.Hide();
        }

        private void regresarprinc_Click(object sender, EventArgs e)
        {
            F2menu f2regre new F2();
            f2regre.show();
            this.Hide();
        }

        private void butonbici_Click(object sender, EventArgs e)
        {
            F2menu f2Bici = new F2bici();
            f2Bici.Show();
            this.Hide();
        }

        private void butonelec_Click(object sender, EventArgs e)
        {
            F2menu f2elec F2mtoelec();
            f2elec.Show();
            this.Hide();
        }
    }
}