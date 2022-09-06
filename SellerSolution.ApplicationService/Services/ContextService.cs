using Microsoft.Extensions.Configuration;
using SellerSolution.ApplicationService.Interfaces;
using SellerSolution.ApplicationService.Request.TransactionData;
using System.Text;

namespace SellerSolution.ApplicationService.Services
{
    public class ContextService : IContextService
    {
        private readonly IConfiguration _configuration;

        public ContextService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SaveAsync(TransationDataSaveRequest transation)
        {
            StreamWriter streamWriter = null;

            try
            {
                streamWriter = new StreamWriter(_configuration["SaveData:Path"], true, Encoding.ASCII);
                await streamWriter.WriteLineAsync($"transaction hour: {transation.RequestHour}");
                await streamWriter.WriteLineAsync($"transaction status: {transation.RequestStatus}");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
        }
    }
}
