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
    public partial class F2 : Form
    {
        public F2()
        {
            InitializeComponent();
        }

        private void R3(object sender, EventArgs e)
        {

        }

        private void F2Aprender(object sender, EventArgs e)
        {
            F2menu f2menu = new F2menu();
            f2menu.Show();
            this.Hide();
        }
    }
}
