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
    public partial class IniSe : Form
    {
        public IniSe()
        {
            InitializeComponent();
        }

        private void S1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuario(object sender, EventArgs e)
        {

        }

        private void Ingresar(object sender, EventArgs e)
        {
            Menu1 menu1 = new Menu1();
            menu1.Show();
            this.Hide();
        }
    }
}
