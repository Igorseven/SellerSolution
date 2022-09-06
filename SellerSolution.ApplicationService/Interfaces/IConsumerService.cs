using SellerSolution.ApplicationService.Responses.Product;

namespace SellerSolution.ApplicationService.Interfaces
{
    public interface IConsumerService
    {
        Task<ProductResponse> GetProductAsync();
    }
}
