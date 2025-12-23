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
    public partial class F3carro : Form
    {
        public F3carro()
        {
            InitializeComponent();
        }

        private void F3carro_Load(object sender, EventArgs e)
        {

        }

        private void R(object sender, EventArgs e)
        {
            F3menu MecaBa = new F3menu();
            MecaBa.Show();
            this.Hide();
        }
    }
}
