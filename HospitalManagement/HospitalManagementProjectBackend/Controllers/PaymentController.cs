using Microsoft.AspNetCore.Mvc;
using HospitalManagementProjectBackend.Services;
using Razorpay.Api;

namespace HospitalManagementProjectBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly RazorpayService _razorpayService;

        public PaymentController(RazorpayService razorpayService)
        {
            _razorpayService = razorpayService;
        }

        #region CreateOrder
        [HttpPost("create-order")]
        public IActionResult CreateOrder([FromBody] int amount)
        {
            try
            {
                var (order, receipt) = _razorpayService.CreateOrder(amount);

                return Ok(new
                {
                    id = order.Attributes["id"]?.ToString(),
                    amount = Convert.ToInt32(order.Attributes["amount"]), // This is in paise
                    amountInRupees = amount, // Original amount in rupees
                    currency = order.Attributes["currency"]?.ToString(),
                    receipt = receipt // Include receipt if needed
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Order creation failed", error = ex.Message });
            }
        }
        #endregion

    }
}
