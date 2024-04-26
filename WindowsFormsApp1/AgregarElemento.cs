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
        private Articulo art = null;
        public AgregarElemento()
        {
            InitializeComponent();
        }

        public AgregarElemento(Articulo art)
        {
            InitializeComponent();
            this.art = art;
        }

        private void AgregarElemento_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            CategoriaNegocio cat = new CategoriaNegocio();
            MarcaNegocio marca = new MarcaNegocio();

            try
            {
                cboxCategoria.DataSource = cat.listarCategorias();
                cboxCategoria.ValueMember = "Id";
                cboxCategoria.DisplayMember = "Descripcion";
                cboxMarca.DataSource = marca.listarMarcas();
                cboxMarca.ValueMember = "Id";
                cboxMarca.DisplayMember = "Descripcion";

                if(art != null)
                {
                    txtCodArt.Text = art.CodArticulo;
                    txtNombreArt.Text=art.NombreArticulo;
                    txtDescripcion.Text=art.Descripcion;
                    tbxUrlImagen.Text = art.ImagenUrl;
                    cargarImagen(art.ImagenUrl);
                    txtPrecio.Text=art.Precio.ToString();
                    cboxCategoria.SelectedValue = art.Categoria.IDCategoria;
                    cboxMarca.SelectedValue = art.Marca.IDMarca;
                }


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
                art.ImagenUrl = tbxUrlImagen.Text;
                art.Marca = (Marca)cboxMarca.SelectedItem;
                art.Categoria = (Categoria)cboxCategoria.SelectedItem;
                art.Precio = decimal.Parse(txtPrecio.Text);

                negocio.agregar(art);
                negocio.agregarImagen(art);
                MessageBox.Show("Agregado correctamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            cargar();


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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxUrlImagen.Text);
        }
            private void cargarImagen(string imagen)
            {
                try
                {
                    pbxArticulo.Load(imagen);
                }
                catch (Exception ex)
                {

                    pbxArticulo.Load("https://www.shutterstock.com/image-vector/ui-image-placeholder-wireframes-apps-260nw-1037719204.jpg");
                }
            }
    }
}
