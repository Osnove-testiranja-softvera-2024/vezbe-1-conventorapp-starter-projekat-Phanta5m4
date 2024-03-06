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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblPocetni.Text = "Pounds";
            lblRezultat.Text = "KG";
        }
        private void rbLength_CheckedChanged(object sender, EventArgs e)
        {
            lblPocetni.Text = "Feet";
            lblRezultat.Text = "M";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbPocetni_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRezultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKonvertuj_Click(object sender, EventArgs e)
        {
            if (rbMass.Checked)
            {
                tbRezultat.Text = MassConvert.ConvertMass(tbPocetni.Text);
            }
            else
            {
                tbRezultat.Text = LenghtConvert.ConvertLenght(tbPocetni.Text);
            }
        }
    }

    public class MassConvert
    {
        public static string ConvertMass(string pocetni)
        {
            double rez = Convert.ToDouble(Convert.ToDouble(pocetni)/2.2046);
            return rez.ToString();
        }
    }

    public class LenghtConvert
    {
        public static string ConvertLenght(string pocetni)
        {
            double rez = Convert.ToDouble(Convert.ToDouble(pocetni) / 2.2046);
            return rez.ToString();
        }
    }
}
