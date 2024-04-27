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
    public partial class AgregarCategoria : Form
    {
        private List<Categoria> lista;
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            if (txtCatDesc.Text != "")
            {
                try
                {
                    cat.NombreCategoria = txtCatDesc.Text;
                    negocio.agregar(cat);
                    MessageBox.Show("Agregado correctamente");
                    Close();

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                lista = negocio.listarCategorias();
                dgvCategoria.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

    }
}
