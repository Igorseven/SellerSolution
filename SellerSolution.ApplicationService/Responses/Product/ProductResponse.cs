using SellerSolution.ApplicationService.Responses.Picture;

namespace SellerSolution.ApplicationService.Responses.Product
{
    public class ProductResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Available_Quantity { get; set; }
        public List<PictureResponse> PictureResponses { get; set; }
    }
}
