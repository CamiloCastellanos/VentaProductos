namespace Entidades
{
    public class RespuestaServicio<T>
    {
        public int estado { get; set; }
        public string mensaje { get; set; }
        public T datos { get; set; }
    }
}
