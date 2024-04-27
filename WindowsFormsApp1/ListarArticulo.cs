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
                ocultarColumnas();
                pbArticulo.Load(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvListArticulos.Columns["ImagenUrl"].Visible = false;
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

        private void dgvListArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cargar();
        }

        private void pbArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado = (Articulo)dgvListArticulos.CurrentRow.DataBoundItem;
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro desea elimiar el artículo?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if(respuesta == DialogResult.OK)
                {
                    negocio.eliminar(seleccionado);
                    MessageBox.Show("Articulo eliminado");
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarElemento ventana = new AgregarElemento();
            ventana.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            seleccionado = (Articulo)dgvListArticulos.CurrentRow.DataBoundItem;

            AgregarElemento modificar = new AgregarElemento(seleccionado);
            modificar.ShowDialog();
            cargar();

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;
            if(filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.NombreArticulo.ToLower().Contains(filtro.ToLower()) || x.CodArticulo.ToLower().Contains(filtro.ToLower()) || x.Descripcion.ToLower().Contains(filtro.ToLower()) || x.Marca.ToString().ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvListArticulos.DataSource = null;
            dgvListArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
    }
}
