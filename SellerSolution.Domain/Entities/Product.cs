namespace SellerSolution.Domain.Entities
{
    public class Product
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Available_Quantity { get; set; }
        public List<Picture> Pictures { get; set; }
    }
}
