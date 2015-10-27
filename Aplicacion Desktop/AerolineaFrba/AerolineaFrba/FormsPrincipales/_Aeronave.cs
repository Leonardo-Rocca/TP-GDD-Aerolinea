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
    public partial class _Aeronave : Form
    {
        public TextBox textBox1;
        public TextBox textBox2;
        public TextBox textBox3;
        public TextBox textBox4;
        public TextBox textBox5;
        public ComboBox combo1;
        public ComboBox combo2;
        public TextBox textBox6;

        public _Aeronave(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5,TextBox t6, ComboBox c1, ComboBox c2)
        {
            InitializeComponent();
            textBox1 = t1;
            textBox2 = t2;
            textBox3 = t3;
            textBox4 = t4;
            textBox5 = t5;
            textBox6 = t6;
            combo1 = c1;
            combo2 = c2;
        }

        private void _Aeronave_Load(object sender, EventArgs e)
        {

        }

    }
}
