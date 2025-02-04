namespace AddressBook.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }
        public int Rating { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCompany { get; set; }
    }
}
