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
            Articulo art = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                art.CodArticulo = txtCodArt.Text;
                art.NombreArticulo = txtNombreArt.Text;
                art.Descripcion = txtDescripcion.Text;
                art.Marca = (Marca)cboxMarca.SelectedItem;
                art.Categoria = (Categoria)cboxCategoria.SelectedItem;

                negocio.agregar(art);
                MessageBox.Show("Agregado correctamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



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

        private void txtCodArt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
