using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

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
            CategoriaNegocio cat = new CategoriaNegocio();
            MarcaNegocio marca = new MarcaNegocio();

            try
            {
                cboxCategoria.DataSource = cat.listarCategorias();
                cboxMarca.DataSource = marca.listarMarcas();
            }
            catch (Exception ex)
            {

                throw ex;
            }

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
            this.Close();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarArticulo ventana = new ListarArticulo();

            ventana.ShowDialog();
            this.Close();
        }
    }
}
