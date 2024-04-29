using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WindowsFormsApp1
{
    public partial class frmMarcas : Form
    {
        private List<Marca> lista;
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            if (txtMarcaDesc.Text != "")
            {
                try
                {
                    marca.NombreMarca = txtMarcaDesc.Text;
                    negocio.agregar(marca);
                    MessageBox.Show("Agregado correctamente");
                    cargar();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Completar el campo");
            }

        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                lista = negocio.listarMarcas();
                dgvMarcas.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro desea elimiar la marca?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.OK)
                {
                    negocio.eliminar(seleccionado);
                    MessageBox.Show("Marca eliminada");
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}
