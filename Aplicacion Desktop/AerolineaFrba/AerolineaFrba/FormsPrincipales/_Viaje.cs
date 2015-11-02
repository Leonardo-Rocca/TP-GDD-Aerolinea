using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.FormsPrincipales
{
    public partial class _Viaje : Form
    {
        public TextBox textBoxMatricula;
        public _Viaje(TextBox text)
        {
            InitializeComponent();
            textBoxMatricula = text;
        }

        private void _Viaje_Load(object sender, EventArgs e)
        {

        }
    }
}
