namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        // it is long because of the payment provider we will be using
        // there is not use decimal points, so we will be shifting the decimal two places to the left
        // it shows in the UI like 100.00 but it is stored in the database as 10000
        
        public string PictureUrl { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public int QuantityInStock { get; set; }

    }
}
