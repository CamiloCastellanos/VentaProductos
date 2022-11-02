using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    public class AccesoDatos
    {
        #region Tipo Documento

        /// <summary>
        /// Retorna la lista de los tipos de documento
        /// </summary>
        /// <returns>Lista de documentos para los clientes</returns>
        public List<TipoDocumento> ListaTipoDocumento()
        {
            List<TipoDocumento> listaTipoDocumentos = new List<TipoDocumento>();
            try
            {
                using (VentasDataContext context = new VentasDataContext())
                {
                    listaTipoDocumentos = context.TipoDocumento.ToList();
                }
            }
            catch
            {
                return new List<TipoDocumento>();
            }
            return listaTipoDocumentos;
        }
        #endregion

        #region Cliente

        /// <summary>
        /// Creacion de Cliente 
        /// </summary>
        /// <param name="nuevoCliente">Informacion del cliente a registrar</param>
        /// <returns>Retorna si fue creado exitosamente</returns>
        public bool CreacionCliente(Cliente nuevoCliente)
        {
            bool creacionExitosa = false;
            try
            {
                using (VentasDataContext context = new VentasDataContext())
                {
                    Cliente cliente = context.Cliente.Where(item =>
                                                                    item.TipoDocumento_Id == nuevoCliente.TipoDocumento_Id &&
                                                                    item.Cliente_Documento.Equals(nuevoCliente.Cliente_Documento)
                                                           ).FirstOrDefault();

                    if (cliente != null)
                    {
                        new Exception("Cliente ya Registrado");
                    }
                    context.Cliente.InsertOnSubmit(nuevoCliente);
                    context.SubmitChanges();
                }
                creacionExitosa = true;
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
        public bool ActualizacionCliente(Cliente informacionCliente)
        {
            bool creacionExitosa = false;
            try
            {
                using (VentasDataContext context = new VentasDataContext())
                {
                    Cliente cliente = context.Cliente.Where(item =>
                                                                    item.TipoDocumento_Id == informacionCliente.TipoDocumento_Id &&
                                                                    item.Cliente_Documento.Equals(informacionCliente.Cliente_Documento)
                                                           ).FirstOrDefault();

                    if (cliente != null)
                    {
                        new Exception("Cliente no esta Registrado.");
                    }

                    cliente.Cliente_Nombre = informacionCliente.Cliente_Nombre;
                    cliente.Cliente_Apellido = informacionCliente.Cliente_Apellido;
                    cliente.Cliente_Telefono = informacionCliente.Cliente_Telefono;
                    cliente.Cliente_Estado = informacionCliente.Cliente_Estado;
                    cliente.Cliente_FechaActualizacion = DateTime.Now;

                    context.SubmitChanges();
                }
                creacionExitosa = true;
            }
            catch
            {
                creacionExitosa = false;
            }
            return creacionExitosa;
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
            bool creacionExitosa = false;
            try
            {
                using (VentasDataContext context = new VentasDataContext())
                {
                    context.Producto.InsertOnSubmit(nuevoProducto);
                    context.SubmitChanges();
                }
                creacionExitosa = true;
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
        /// <param name="informacionProducto">Informacion del cliente a actualizar </param>
        /// <returns>Retorna si fue actualizado exitosamente</returns>
        public bool ActualizacionProducto(Producto informacionProducto)
        {
            bool creacionExitosa = false;
            try
            {
                using (VentasDataContext context = new VentasDataContext())
                {
                    Producto producto = context.Producto.Where(item =>
                                                                        item.Producto_Id == informacionProducto.Producto_Id
                                                               ).FirstOrDefault();

                    if (producto != null)
                    {
                        new Exception("Producto no esta Registrado.");
                    }

                    producto.Producto_Nombre = informacionProducto.Producto_Nombre;
                    producto.Producto_ValorUnitario = informacionProducto.Producto_ValorUnitario;
                    producto.Producto_Estado = informacionProducto.Producto_Estado;
                    producto.Producto_FechaActualizacion = DateTime.Now;

                    context.SubmitChanges();
                }
                creacionExitosa = true;
            }
            catch
            {
                creacionExitosa = false;
            }
            return creacionExitosa;
        }

        #endregion

        #region Venta

        /// <summary>
        /// Creacion de Venta 
        /// </summary>
        /// <param name="nuevoCliente">Informacion de la venta a registrar</param>
        /// <returns>Retorna si fue creado exitosamente</returns>
        public bool CreacionVenta(Venta nuevaVenta)
        {
            bool creacionExitosa = false;
            try
            {
                using (VentasDataContext context = new VentasDataContext())
                {
                    context.Venta.InsertOnSubmit(nuevaVenta);
                    context.SubmitChanges();
                }
                creacionExitosa = true;
            }
            catch
            {
                creacionExitosa = false;
            }
            return creacionExitosa;
        }

        #endregion

    }
}
