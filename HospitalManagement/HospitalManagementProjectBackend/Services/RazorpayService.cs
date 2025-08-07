using Microsoft.Extensions.Options;
using Razorpay.Api;
using HospitalManagementProjectBackend.Models;

namespace HospitalManagementProjectBackend.Services
{
    public class RazorpayService
    {
        private readonly RazorpaySettings _settings;

        public RazorpayService(IOptions<RazorpaySettings> settings)
        {
            _settings = settings.Value;
        }

        public (Order, string) CreateOrder(int amount, string currency = "INR", string receipt = "receipt_001")
        {
            // Razorpay expects amount in paise
            int amountInPaise = amount * 100;

            Dictionary<string, object> options = new Dictionary<string, object>
            {
                { "amount", amountInPaise },
                { "currency", currency },
                { "receipt", receipt }
            };

            RazorpayClient client = new RazorpayClient(_settings.Key, _settings.Secret);
            Order order = client.Order.Create(options);
            return (order, _settings.Key); // Return both order and Key
        }
    }
}
