﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listarMarcas()
        {
            List<Marca> ListaMarcas = new List<Marca>();  
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT id,descripcion FROM MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.IDMarca = (int)datos.Lector["ID"];
                    aux.NombreMarca = (string)datos.Lector["Descripcion"];

                    ListaMarcas.Add(aux);
                }

                return ListaMarcas;
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
