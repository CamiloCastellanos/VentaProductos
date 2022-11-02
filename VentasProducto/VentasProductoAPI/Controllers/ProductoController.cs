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
    [Route("Producto")]
    public class ProductoController : ApiController
    {
        [HttpPost]
        [Route("CreacionProducto")]
        /// <summary>
        /// Creacion del Producto 
        /// </summary>
        /// <param name="nuevoProducto">Informacion del producto a registrar</param>
        /// <returns>Retorna si fue creado exitosamente</returns>
        public RespuestaServicio<bool> CreacionProducto(Producto nuevoProducto)
        {
            try
            {
                bool creacionExitosa = new AccesoNegocio().CreacionProducto(nuevoProducto);

                return new RespuestaServicio<bool>()
                {
                    estado = HttpStatusCode.OK.GetHashCode(),
                    mensaje = creacionExitosa
                                ? string.Concat("Creacion exitosa del Producto: ", nuevoProducto.nombre)
                                : "Ocurrio una falla al crear el usuario, por favor intente más tarde",
                    datos = creacionExitosa
                };
            }
            catch
            {
                return new RespuestaServicio<bool>()
                {
                    estado = HttpStatusCode.InternalServerError.GetHashCode(),
                    mensaje =  "Ocurrio una falla al crear el producto, por favor intente más tarde",
                    datos = false
                };
            }
        }

        [HttpPost]
        [Route("ActualizacionProducto")]
        /// <summary>
        /// Actualizacion de Informacion del cliente 
        /// </summary>
        /// <param name="informacionProducto">Informacion del producto a actualizar </param>
        /// <returns>Retorna si fue actualizado exitosamente</returns>
        public RespuestaServicio<bool> ActualizacionProducto(Producto informacionProducto)
        {
            try
            {
                bool creacionExitosa = new AccesoNegocio().ActualizacionProducto(informacionProducto);

                return new RespuestaServicio<bool>()
                {
                    estado = HttpStatusCode.OK.GetHashCode(),
                    mensaje = creacionExitosa
                                ? string.Concat("Actualizacion exitosa")
                                : "Ocurrio una falla al crear el usuario, por favor intente más tarde",
                    datos = creacionExitosa
                };
            }
            catch
            {
                return new RespuestaServicio<bool>()
                {
                    estado = HttpStatusCode.InternalServerError.GetHashCode(),
                    mensaje = "Ocurrio una falla al actualizar el producto, por favor intente más tarde",
                    datos = false
                };
            }
        }
    }
}