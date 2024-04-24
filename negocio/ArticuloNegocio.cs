using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using dominio;



namespace negocio
{
    public class ArticuloNegocio
    {
       public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Nombre, Codigo,a.Descripcion,Precio,i.ImagenUrl,a.IdMarca,m.Descripcion Marca ,a.IdCategoria, c.Descripcion Categoria, a.Id FROM ARTICULOS a, MARCAS m, CATEGORIAS c, IMAGENES i WHERE m.Id = a.IdMarca and c.Id = a.IdCategoria and i.IdArticulo = a.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Articulo aux = new Articulo();

                    aux.ID = (int)datos.Lector["Id"];
                    aux.NombreArticulo = (string)datos.Lector["Nombre"];
                    aux.CodArticulo = (string)datos.Lector["Codigo"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.IDMarca = new Marca();
                    aux.IDCategoria.IDCategoria= (int)datos.Lector["IdMarca"];
                    aux.IDMarca.NombreMarca = (string)datos.Lector["Marca"];
                    aux.IDCategoria = new Categoria();
                    aux.IDCategoria.IDCategoria = (int)datos.Lector["IdCategoria"];
                    aux.IDCategoria.NombreCategoria = (string)datos.Lector["Categoria"];


                    lista.Add(aux);


                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();

            }

        }
    }
}
