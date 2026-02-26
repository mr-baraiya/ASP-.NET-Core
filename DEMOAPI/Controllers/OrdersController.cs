using DEMOAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DEMOAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly DemoApiDbContext _context;

        public OrdersController(DemoApiDbContext context)
        {
            _context = context;
        }

        #region Get All Orders

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            try
            {
                var orders = await _context.Orders
                    .Include(o => o.User)
                    .ToListAsync();

                return Ok(orders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        #endregion


        #region Get Order By Id

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            try
            {
                var order = await _context.Orders
                    .Include(o => o.User)
                    .FirstOrDefaultAsync(o => o.Id == id);

                if (order == null)
                    return NotFound("Order not found");

                return Ok(order);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        #endregion


        #region Create Order

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order model)
        {
            try
            {
                await _context.Orders.AddAsync(model);
                await _context.SaveChangesAsync();

                return Ok("Order Created Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        #endregion


        #region Update Order

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, Order model)
        {
            try
            {
                var order = await _context.Orders.FindAsync(id);

                if (order == null)
                    return NotFound("Order not found");

                order.OrderNumber = model.OrderNumber;
                order.TotalAmount = model.TotalAmount;
                order.UserId = model.UserId;

                await _context.SaveChangesAsync();

                return Ok("Order Updated Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        #endregion


        #region Delete Order

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            try
            {
                var order = await _context.Orders.FindAsync(id);

                if (order == null)
                    return NotFound("Order not found");

                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();

                return Ok("Order Deleted Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        #endregion

    }
}