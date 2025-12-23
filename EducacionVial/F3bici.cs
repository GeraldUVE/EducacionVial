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
    public partial class F3bici : Form
    {
        public F3bici()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void R(object sender, EventArgs e)
        {
            F3menu menu2 = new F3menu();
            menu2.Show();
            this.Hide();
        }
    }
}
