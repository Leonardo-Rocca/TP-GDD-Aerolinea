﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Top5
{
    public partial class DiscriminadorTop5 : Form
    {
        public DiscriminadorTop5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DestinosConMasPasajesComprados dest = new DestinosConMasPasajesComprados(this,1);
            dest.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DestinosConMasPasajesComprados dest = new DestinosConMasPasajesComprados(this, 5);
            dest.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DestinosConMasPasajesComprados dest = new DestinosConMasPasajesComprados(this, 2);
            dest.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DestinosConMasPasajesComprados dest = new DestinosConMasPasajesComprados(this, 3);
            dest.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DestinosConMasPasajesComprados dest = new DestinosConMasPasajesComprados(this, 4);
            dest.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
