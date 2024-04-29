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
                datos.setearConsulta("SELECT Nombre, Codigo,a.Descripcion,Precio,i.ImagenUrl,m.Descripcion AS Marca, a.IdCategoria,c.Descripcion AS Categoria,a.IdMarca,a.Id FROM ARTICULOS a INNER JOIN MARCAS m ON m.Id = a.IdMarca INNER JOIN CATEGORIAS c ON c.Id = a.IdCategoria INNER JOIN IMAGENES i ON i.IdArticulo = a.Id");
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
                    aux.Marca.IDMarca = (int)datos.Lector["IdMarca"];
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
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio) VALUES (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@Precio)");
                datos.setearParametros("@Codigo", nuevo.CodArticulo);
                datos.setearParametros("@Nombre", nuevo.NombreArticulo);
                datos.setearParametros("@Descripcion", nuevo.Descripcion);
                datos.setearParametros("@IdMarca", nuevo.Marca.IDMarca);
                datos.setearParametros("@IdCategoria", nuevo.Categoria.IDCategoria);
                datos.setearParametros("@Precio", nuevo.Precio);
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
        //public string RecuperarIDArt(string codigo)
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        //datos.setearConsulta("SELECT ID FROM ARTICULOS WHERE CODIGO = @CodigoArt");
        //        //datos.setearParametros("@CodigoArt", codigo);
        //        //string idArt = datos.EjecutaScalar();

        //        //SqlCommand cmd = new SqlCommand("SELECT ID FROM ARTICULOS WHERE CODIGO = @CodigoArt");
        //        //cmd.Parameters.AddWithValue("@CodigoArt", codigo);
        //        //string idArt = (string)cmd.ExecuteScalar();

        //        return idArt;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
           
        //}


        public void agregarImagen(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo,ImagenUrl) VALUES (@IdArticulo,@ImagenUrl)");
                datos.setearParametros("@IdArticulo", art.ID);
                datos.setearParametros("@ImagenUrl", art.ImagenUrl);

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

        public void modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("");
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @desc, IdMarca = @IdMarca, IdCategoria = @IdCat , Precio = @precio WHERE Id = @Id");
                datos.setearParametros("@codigo", art.CodArticulo);
                datos.setearParametros("@nombre", art.NombreArticulo);
                datos.setearParametros("@desc", art.Descripcion);
                datos.setearParametros("@IdMarca", art.Marca.IDMarca);
                datos.setearParametros("@IdCat", art.Categoria.IDCategoria);
                datos.setearParametros("@precio", art.Precio);
                datos.setearParametros("@Id", art.ID);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarImagen(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("");
                datos.setearConsulta("UPDATE IMAGENES SET ImagenUrl = @img WHERE Id = @Id");
                datos.setearParametros("@img", art.ImagenUrl);
                datos.setearParametros("@Id", art.ID);
                datos.ejecutarAccion();

            }
            catch (Exception EX1)
            {

                throw EX1;
            }
        }

        public List<Articulo> filtroAvanzado(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT Nombre, Codigo,a.Descripcion,Precio,i.ImagenUrl,m.Descripcion AS Marca, a.IdCategoria,c.Descripcion AS Categoria,a.IdMarca,a.Id FROM ARTICULOS a INNER JOIN MARCAS m ON m.Id = a.IdMarca INNER JOIN CATEGORIAS c ON c.Id = a.IdCategoria LEFT JOIN IMAGENES i ON i.IdArticulo = a.Id WHERE ";
                switch (campo)
                {
                    case "Codigo":
                        if(criterio == "Igual a")
                        {
                            consulta += "Codigo = '" + filtro + "'";
                        }
                        else
                        {
                            consulta += "Codigo like '%" + filtro + "%'";
                        }
                    break;

                    case "Nombre":
                        if (criterio == "Igual a")
                        {
                            consulta += "Nombre = '" + filtro +"'";
                        }
                        else
                        {
                            consulta += "Nombre like '%" + filtro + "%'";
                        }
                    break;

                    default:
                        switch (criterio)
                        {
                            case "Mayor que":
                                consulta += "Precio > " + filtro;
                            break;
                            case "Menor que":
                                consulta += "Precio < " + filtro;
                            break;
                            default:
                                consulta += "Precio = " + filtro;
                            break;
                        }
                    break;

                }
                datos.setearConsulta(consulta);
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
                    aux.Marca.IDMarca = (int)datos.Lector["IdMarca"];
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
        }
    }
}
