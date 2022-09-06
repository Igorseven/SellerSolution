using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SellerSolution.ApplicationService.AutoMapperConfigurations;
using SellerSolution.ApplicationService.Interfaces;
using SellerSolution.ApplicationService.Request.TransactionData;
using SellerSolution.ApplicationService.Responses.Product;
using SellerSolution.Domain.Entities;
using System.Net;
using System.Net.Http.Json;

namespace SellerSolution.ApplicationService.Services
{
    public class ConsumerService : IConsumerService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly ILogger<ConsumerService> _logger;
        private readonly IContextService _contextService;

        public ConsumerService(IConfiguration configuration, ILogger<ConsumerService> logger, IContextService contextService)
        {
            _httpClient = new HttpClient();
            _configuration = configuration;
            _logger = logger;
            _contextService = contextService;
        }

        public async Task<ProductResponse> GetProductAsync()
        {
            var httpResponse = await _httpClient.GetAsync(_configuration["GetDataToMC:Url"]);

            var transactionHour = httpResponse.Headers.Date;
            var requestStatus = httpResponse.StatusCode;

            var transaction = CreateTransactionData(requestStatus, transactionHour);
            var product = await httpResponse.Content.ReadFromJsonAsync<Product>();
            await _contextService.SaveAsync(transaction);

            if (product != null)
            {
                _logger.LogInformation("Produto Encontrado");
                return product.MapTo<Product, ProductResponse>();
            }

            _logger.LogError("Produto não encontrado");
            return null;
        }

        private TransationDataSaveRequest CreateTransactionData(HttpStatusCode status, DateTimeOffset? hour)
        {
            return new TransationDataSaveRequest
            {
                RequestStatus = status.ToString(),
                RequestHour = hour != null ? hour.ToString() : ""
            };
        }
    }
}
