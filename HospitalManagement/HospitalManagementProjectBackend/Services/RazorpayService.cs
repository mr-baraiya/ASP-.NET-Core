using Razorpay.Api;

namespace HospitalManagementProject.Services
{
    public class RazorpayService
    {
        private readonly string key = "YOUR_KEY_ID";
        private readonly string secret = "YOUR_KEY_SECRET";

        public Order CreateOrder(int amount)
        {
            RazorpayClient client = new RazorpayClient(key, secret);
            Dictionary<string, object> options = new Dictionary<string, object>();
            options.Add("amount", amount * 100); // in paise
            options.Add("currency", "INR");
            options.Add("receipt", $"order_rcptid_{Guid.NewGuid()}");

            Order order = client.Order.Create(options);
            return order;
        }
    }
}

