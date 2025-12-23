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
    public partial class F3menu : Form
    {
        public F3menu()
        {
            InitializeComponent();
        }

        private void BtCarro(object sender, EventArgs e)
        {
            F3carro f3carro = new F3carro();
            f3carro.Show();
            this.Hide();
        }

        private void R(object sender, EventArgs e)
        {
            Menu2 menu2 = new Menu2();
            menu2.Show();
            this.Hide();
        }

        private void BtMotoEle(object sender, EventArgs e)
        {
            F3motoelec motoelec = new F3motoelec();
            motoelec.Show();
            this.Hide();
        }

        private void Motos(object sender, EventArgs e)
        {
            F3moto moto = new F3moto();
            moto.Show();
            this.Hide();
        }

        private void Bici(object sender, EventArgs e)
        {
            F3bici bici = new F3bici();
            bici.Show();
            this.Hide();
        }
    }
}
