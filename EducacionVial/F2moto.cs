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
    public partial class F2moto : Form
    {
        public F2moto()
        {
            InitializeComponent();
        }

        private void R(object sender, EventArgs e)
        {
            F2menu f2menu = new F2menu();
            f2menu.Show();
            this.Hide();
        }
    }
}
