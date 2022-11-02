using Repositorio;
using System.Collections.Generic;

namespace Negocio.Negocio
{
    public class ClienteBO
    {
        /// <summary>
        /// Retorna la lista de los tipos de documento
        /// </summary>
        /// <returns>Lista de documentos para los clientes</returns>
        public List<Entidades.ListaDesplegable> ListaTipoDocumento()
        {
            List<Entidades.ListaDesplegable> listaTipoDocumentos = new List<Entidades.ListaDesplegable>();
            try
            {
                List<TipoDocumento> tipoDocumentos = new AccesoDatos().ListaTipoDocumento();


            }
            catch
            {
                return new List<Entidades.ListaDesplegable>();
            }
            return listaTipoDocumentos;
        }

        /// <summary>
        /// Creacion de Cliente 
        /// </summary>
        /// <param name="nuevoCliente">Informacion del cliente a registrar</param>
        /// <returns>Retorna si fue creado exitosamente</returns>
        public bool CreacionCliente(Entidades.Cliente nuevoCliente)
        {
            bool creacionExitosa = false;
            try
            {
                Cliente cliente = new Cliente();
                return new AccesoDatos().CreacionCliente(cliente);
            }
            catch
            {
                creacionExitosa = false;
            }
            return creacionExitosa;
        }

        /// <summary>
        /// Actualizacion de Informacion del cliente 
        /// </summary>
        /// <param name="informacionCliente">Informacion del cliente a actualizar </param>
        /// <returns>Retorna si fue actualizado exitosamente</returns>
        public bool ActualizacionCliente(Entidades.Cliente informacionCliente)
        {
            try
            {
                Cliente cliente = new Cliente();
                return new AccesoDatos().ActualizacionCliente(cliente);
            }
            catch
            {
                return false;
            }
        }
    }
}
