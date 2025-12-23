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

        private void BUTONREGREMOTO_Click(object sender, EventArgs e)
        {
            F2moto f2moto = new F2menu();
            f2moto.show();
            this.Hide();
        }
    }
}
