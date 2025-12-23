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
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void S3(object sender, EventArgs e)
        {
            this.Close();
        }

        private void R2(object sender, EventArgs e)
        {
            Menu1 menu1 = new Menu1();
            menu1.Show();
            this.Hide();
        }

        private void F2Ingre(object sender, EventArgs e)
        {
            F2 InsVial = new F2();
            InsVial.Show();
            this.Hide();
        }

        private void F3Ingre(object sender, EventArgs e)
        {
            F3menu MecaBa = new F3menu();
            MecaBa.Show();
            this.Hide();
        }
    }
}
