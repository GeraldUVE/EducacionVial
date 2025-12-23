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

        private void R4(object sender, EventArgs e)
        {
            F2 F2 = new F2();
            F2.Show();
            this.Hide();
        }

        private void Carro(object sender, EventArgs e)
        {
            F2Carro f2carro = new F2Carro();
            f2carro.Show();
            this.Hide();
        }

        private void Bici(object sender, EventArgs e)
        {

        }

        private void Moto(object sender, EventArgs e)
        {

        }

        private void MotoEle(object sender, EventArgs e)
        {

        }
    }
}