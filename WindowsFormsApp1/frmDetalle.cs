using dominio;
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
    public partial class frmDetalle : Form
    {
        private Articulo art = null;
        public frmDetalle()
        {
            InitializeComponent();
        }

        public frmDetalle(Articulo art)
        {
            InitializeComponent();
            this.art = art;
            Text = "Detalle Articulo";

        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = art.ID.ToString();
                txtCodigo.Text = art.CodArticulo.ToString();
                txtNombre.Text = art.NombreArticulo.ToString();
                txtDescripcion.Text = art.Descripcion.ToString();
                txtMarca.Text = art.Marca.NombreMarca.ToString();
                txtCategoria.Text = art.Categoria.NombreCategoria.ToString();
                txtPrecio.Text = art.Precio.ToString();
                cargarImagen(art.ImagenUrl);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDetalle.Load(imagen);
            }
            catch (Exception)
            {

                pbxDetalle.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }
    }
}
