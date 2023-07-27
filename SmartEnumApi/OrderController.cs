using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartEnumApi.Repository;

namespace SmartEnumApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly TestDBContext _context;

        public OrderController(TestDBContext context)
        {
            _context = context;
        }

        // GET: api/order
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return await _context.orders.ToListAsync();
        }

        // POST: api/order
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder([FromBody] DtoOrder order)
        {
            _context.orders.Add(new Order() { id = order.Id,status= StatusEnum.FromValue(order.Status)});
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrders", new { id = order.Id }, order);
        }
    }
}
