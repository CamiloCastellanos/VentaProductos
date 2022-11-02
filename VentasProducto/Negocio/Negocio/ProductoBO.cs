using Repositorio;

namespace Negocio.Negocio
{
    public class ProductoBO
    {
        /// <summary>
        /// Creacion del Producto 
        /// </summary>
        /// <param name="nuevoProducto">Informacion del procuto a registrar</param>
        /// <returns>Retorna si fue creado exitosamente</returns>
        public bool CreacionProducto(Entidades.Producto nuevoProducto)
        {
            try
            {
                Producto producto = new Producto();
                return new AccesoDatos().CreacionProducto(producto);
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
        public bool ActualizacionProducto(Entidades.Producto informacionProducto)
        {
            try
            {
                Producto producto = new Producto();
                return new AccesoDatos().ActualizacionProducto(producto);
            }
            catch
            {
                return false;
            }
        }
    }
}
