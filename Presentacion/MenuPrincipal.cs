using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MICRUD.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            PanelBienvenida.Dock=DockStyle.Fill;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            Personal control = new Personal();
            control.Dock = DockStyle.Fill; 
            PanelPadre.Controls.Add(control);
        }
    }
}
