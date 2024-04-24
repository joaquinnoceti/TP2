using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;




namespace WindowsFormsApp1
{
    public partial class ListarArticulo : Form
    {

        private List<Articulo> listaArticulos;
        public ListarArticulo()
        {
            InitializeComponent();
        }

        private void ListarArticulo_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.Listar();
                dgvListArticulos.DataSource = listaArticulos;
                pbArticulo.Load(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvListArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvListArticulos.CurrentRow.DataBoundItem; 
            cargarImagen(seleccionado.ImagenUrl);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbArticulo.Load("https://www.shutterstock.com/image-vector/ui-image-placeholder-wireframes-apps-260nw-1037719204.jpg");
            }
        }
    }
}
