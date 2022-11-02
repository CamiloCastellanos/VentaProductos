using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VentasProductoAPI.Controllers
{
    [Route("Cliente")]
    public class ClienteController : ApiController
    {
        [Route("ListaTipoDocumento")]
        [HttpGet]
        /// <summary>
        /// Retorna la lista de los tipos de documento
        /// </summary>
        /// <returns>Lista de documentos para los clientes</returns>
        public RespuestaServicio<List<ListaDesplegable>> ListaTipoDocumento()
        {
            try
            {
                RespuestaServicio<List<ListaDesplegable>> respuesta = new RespuestaServicio<List<ListaDesplegable>>();
                List<ListaDesplegable> listaDesplegables = new AccesoNegocio().ListaTipoDocumento();
                return new RespuestaServicio<List<ListaDesplegable>>()
                {
                    estado = HttpStatusCode.OK.GetHashCode(),
                    mensaje = string.Empty,
                    datos = listaDesplegables
                };
            }
            catch
            {
                return new RespuestaServicio<List<ListaDesplegable>>()
                {
                    estado = HttpStatusCode.InternalServerError.GetHashCode(),
                    mensaje = "Ocurrio una falla al obtener la lista de tipos de documentos, por favor intente más tarde",
                    datos = null
                };
            }

        }

        [Route("CreacionCliente")]
        [HttpPost]
        /// <summary>
        /// Creacion de Cliente 
        /// </summary>
        /// <param name="nuevoCliente">Informacion del cliente a registrar</param>
        /// <returns>Retorna si fue creado exitosamente</returns>
        public RespuestaServicio<bool> CreacionCliente(Cliente nuevoCliente)
        {
            try
            {
                bool creacionExitosa = new AccesoNegocio().CreacionCliente(nuevoCliente);

                return new RespuestaServicio<bool>()
                {
                    estado = HttpStatusCode.OK.GetHashCode(),
                    mensaje = creacionExitosa 
                                ? string.Concat("Creacion exitosa del Usuario: ", nuevoCliente.nombre, " ", nuevoCliente.apellidos)
                                : "Ocurrio una falla al crear el usuario, por favor intente más tarde",
                    datos = creacionExitosa
                };
            }
            catch
            {
                return new RespuestaServicio<bool>()
                {
                    estado = HttpStatusCode.InternalServerError.GetHashCode(),
                    mensaje = "Ocurrio una falla al crear el usuario, por favor intente más tarde",
                    datos = false
                };
            }

        }

        [Route("ActualizacionCliente")]
        [HttpPost]
        /// <summary>
        /// Actualizacion de Informacion del cliente 
        /// </summary>
        /// <param name="informacionCliente">Informacion del cliente a actualizar </param>
        /// <returns>Retorna si fue actualizado exitosamente</returns>
        public RespuestaServicio<bool> ActualizacionCliente(Cliente informacionCliente)
        {
            try
            {
                bool actualizacionExitosa = new AccesoNegocio().ActualizacionCliente(informacionCliente);

                return new RespuestaServicio<bool>()
                {
                    estado = HttpStatusCode.OK.GetHashCode(),
                    mensaje = actualizacionExitosa
                                ? string.Concat("Actualizacion exitosa")
                                : "Ocurrio una falla al obtener actualizar el cliente, por favor intente más tarde",
                    datos = actualizacionExitosa
                };
            }
            catch
            {
                return new RespuestaServicio<bool>()
                {
                    estado = HttpStatusCode.InternalServerError.GetHashCode(),
                    mensaje = "Ocurrio una falla al obtener actualizar el cliente, por favor intente más tarde",
                    datos = false
                };
            }
        }

    }
}