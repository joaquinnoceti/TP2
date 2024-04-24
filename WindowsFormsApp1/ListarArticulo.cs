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
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


    }
}
