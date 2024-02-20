using System.Runtime.ConstrainedExecution;

namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        //podria ser decimal pero es long por el proveedor de pagos que se va a utilizar
        // se debe correr el decimal dos campos a la izquierda para obtener el precio, se muestra como 100.00 pero se almacena como 10000
        public string PictureUrl { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public int QuantityInStock { get; set; }

    }
}
