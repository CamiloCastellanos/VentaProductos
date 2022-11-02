using Entidades;
using Negocio.Negocio;
using System.Collections.Generic;

namespace Negocio
{
    public class AccesoNegocio
    {
        #region Cliente

        /// <summary>
        /// Retorna la lista de los tipos de documento
        /// </summary>
        /// <returns>Lista de documentos para los clientes</returns>
        public List<ListaDesplegable> ListaTipoDocumento()
        {
            try
            {
                return new ClienteBO().ListaTipoDocumento();
            }
            catch
            {
                return new List<Entidades.ListaDesplegable>();
            }
        }

        /// <summary>
        /// Creacion de Cliente 
        /// </summary>
        /// <param name="nuevoCliente">Informacion del cliente a registrar</param>
        /// <returns>Retorna si fue creado exitosamente</returns>
        public bool CreacionCliente(Cliente nuevoCliente)
        {
            try
            {
                return new ClienteBO().CreacionCliente(nuevoCliente);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Actualizacion de Informacion del cliente 
        /// </summary>
        /// <param name="informacionCliente">Informacion del cliente a actualizar </param>
        /// <returns>Retorna si fue actualizado exitosamente</returns>
        public bool ActualizacionCliente(Cliente informacionCliente)
        {
            try
            {               
                return new ClienteBO().ActualizacionCliente(informacionCliente);
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Producto
        /// <summary>
        /// Creacion del Producto 
        /// </summary>
        /// <param name="nuevoProducto">Informacion del procuto a registrar</param>
        /// <returns>Retorna si fue creado exitosamente</returns>
        public bool CreacionProducto(Producto nuevoProducto)
        {
            try
            {
                return new ProductoBO().CreacionProducto(nuevoProducto);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Actualizacion de Informacion del cliente 
        /// </summary>
        /// <param name="informacionProducto">Informacion del cliente a actualizar </param>
        /// <returns>Retorna si fue actualizado exitosamente</returns>
        public bool ActualizacionProducto(Producto informacionProducto)
        {
            try
            {
                return new ProductoBO().ActualizacionProducto(informacionProducto);
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
