using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void rbMass_CheckedChanged_1(object sender, EventArgs e)
        {
            lblPocetni.Text = "Pounds:";
            lblRezultat.Text = "KG:";
            lblPocetni.Location = new Point(58, 138);
            lblRezultat.Location = new Point(75, 168);
        }

        private void rbLength_CheckedChanged(object sender, EventArgs e)
        {
            lblPocetni.Text = "Feet:";
            lblRezultat.Text = "M:";
            lblPocetni.Location = new Point(66, 138);
            lblRezultat.Location = new Point(80, 168);
        }

        private void btnKonvertuj_Click(object sender, EventArgs e)
        {
            MassConvert massConvert = new MassConvert();
            LenghtConvert lenghtConvert = new LenghtConvert();

            if (rbMass.Checked)
            {
                tbRezultat.Text = massConvert.Convert(tbPocetni.Text);
            }
            else if (rbLength.Checked)
            {
                tbRezultat.Text = lenghtConvert.Convert(tbPocetni.Text);
            }
            else
                MessageBox.Show("Nije selektovan ni jedan konvertor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
