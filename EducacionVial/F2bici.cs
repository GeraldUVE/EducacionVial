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
    public partial class F2bici : Form
    {
        public F2bici()
        {
            InitializeComponent();
        }

        private void BUTONREGREBICI_Click(object sender, EventArgs e)
        {
            F2bici biciregre F2menu();
            biciregre.Show();
            this.Hide();
        }
    }
}
