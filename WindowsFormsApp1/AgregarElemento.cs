using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class AgregarElemento : Form
    {
        public AgregarElemento()
        {
            InitializeComponent();
        }

        private void AgregarElemento_Load(object sender, EventArgs e)
        {
            cboxCategoria.Items.Add("Eletrodomestico");
            cboxCategoria.Items.Add("Vehiculo");
            cboxCategoria.Items.Add("Insumos");

            cboxMarca.Items.Add("Honda");
            cboxMarca.Items.Add("Daiatsu");
            cboxMarca.Items.Add("Marolio");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codArt = txtCodArt.Text;
            string NombreArt = txtNombreArt.Text;
            string descr = txtDescripcion.Text;
            string marcaArt = cboxMarca.Text;
            string catArt = cboxCategoria.Text;
            float precio = float.Parse(txtPrecio.Text);
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
