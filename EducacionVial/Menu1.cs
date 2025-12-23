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
    public partial class Menu1 : Form
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void S2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void R1(object sender, EventArgs e)
        {
            IniSe inise = new IniSe();
            inise.Show();
            this.Hide();
        }

        private void Objetivo(object sender, EventArgs e)
        {

        }

        private void Funcionalidades(object sender, EventArgs e)
        {
            Menu2 menu2 = new Menu2();
            menu2.Show();
            this.Hide();
        }
    }
}
