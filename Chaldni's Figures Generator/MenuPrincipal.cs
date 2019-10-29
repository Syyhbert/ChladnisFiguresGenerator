using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaldni_s_Figures_Generator
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void GeneradorFrecuencias_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Primerhz_Click(object sender, EventArgs e)
        {
            _345Hz Forma345 = new _345Hz();
            Forma345.Show();
        }

        private void Miltreinta3_Click(object sender, EventArgs e)
        {
            _1033Hz Forma1033Hz = new _1033Hz();
            Forma1033Hz.Show();
        }

        private void Milochocientos_Click(object sender, EventArgs e)
        {
            _1820Hz Forma1820 = new _1820Hz();
            Forma1820.Show();
        }

        private void dosmil41_Click(object sender, EventArgs e)
        {
            _2041Hz Forma2041Hz = new _2041Hz();
            Forma2041Hz.Show();
        }

        private void tresmil240_Click(object sender, EventArgs e)
        {
            _3240Hz Forma3240 = new _3240Hz();
            Forma3240.Show();
        }

        private void tresmil835_Click(object sender, EventArgs e)
        {
            _3835Hz Forma3835Hz = new _3835Hz();
            Forma3835Hz.Show();
        }

        private void tresmil975_Click(object sender, EventArgs e)
        {
            _3975Hz Forma3975Hz = new _3975Hz();
            Forma3975Hz.Show();
        }

        private void cuarentamil129_Click(object sender, EventArgs e)
        {
            _4129Hz Forma4129Hz = new _4129Hz();
            Forma4129Hz.Show();
        }

        private void cuatromil173_Click(object sender, EventArgs e)
        {
            _4173Hz Forma4173Hz = new _4173Hz();
            Forma4173Hz.Show();
        }

        private void Cuatromil221_Click(object sender, EventArgs e)
        {
            _4221Hz Forma4421Hz = new _4221Hz();
            Forma4421Hz.Show();
        }

        private void cuatrol444_Click(object sender, EventArgs e)
        {
            _4444Hz Forma4444Hz = new _4444Hz();
            Forma4444Hz.Show();
        }

        private void cuatrol671_Click(object sender, EventArgs e)
        {
            _4671Hz Forma4671Hz = new _4671Hz();
            Forma4671Hz.Show();
        }

        private void cuatro840_Click(object sender, EventArgs e)
        {
            _4840Hz Forma4840 = new _4840Hz();
            Forma4840.Show();
        }

        private void Cinco201_Click(object sender, EventArgs e)
        {
            _5201Hz Forma5201 = new _5201Hz();
            Forma5201.Show();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
