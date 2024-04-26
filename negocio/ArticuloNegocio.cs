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
                datos.setearConsulta("SELECT Nombre, Codigo,a.Descripcion,Precio,i.ImagenUrl,m.Descripcion AS Marca, a.IdCategoria,c.Descripcion AS Categoria,a.IdMarca,a.Id FROM ARTICULOS a INNER JOIN MARCAS m ON m.Id = a.IdMarca INNER JOIN CATEGORIAS c ON c.Id = a.IdCategoria LEFT JOIN IMAGENES i ON i.IdArticulo = a.Id");
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
                    aux.Marca = new Marca();
                    aux.Marca.IDMarca= (int)datos.Lector["IdMarca"];
                    aux.Marca.NombreMarca = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.IDCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.NombreCategoria = (string)datos.Lector["Categoria"];


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

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS(Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio)VALUES('" + nuevo.CodArticulo + "','" + nuevo.NombreArticulo + "','" + nuevo.Descripcion + "','" + nuevo.Marca.IDMarca + "','" + nuevo.Categoria.IDCategoria + "','" + nuevo.Precio +"')");
                datos.ejecutarAccion();
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

        public void agregarImagen(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES(IdArticulo,ImagenUrl)VALUES('" + art.ID + "','" + art.ImagenUrl + "')");
                datos.ejecutarAccion();
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

        public void eliminar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Delete FROM ARTICULOS Where Codigo ='" + art.CodArticulo + "'");
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }

}
