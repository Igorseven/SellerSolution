using SellerSolution.ApplicationService.Request.TransactionData;

namespace SellerSolution.ApplicationService.Interfaces
{
    public interface IContextService
    {
        Task SaveAsync(TransationDataSaveRequest transation);
    }
}
