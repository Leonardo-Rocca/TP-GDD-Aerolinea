using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class llegadaAvionForm : Form
    {
        private string p;

        public llegadaAvionForm()
        {
            InitializeComponent();
        }

        public llegadaAvionForm(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
