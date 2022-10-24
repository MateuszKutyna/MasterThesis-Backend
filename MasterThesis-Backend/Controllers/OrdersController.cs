using MasterThesis_Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace MasterThesis_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrdersController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet("GetAllOrders")]
        public ActionResult<List<Order>> GetAllOrders()
        {
            return Ok(orderService.GetAllOrders());
        }

        [HttpDelete("{steelGrade}")]
        public ActionResult<Order> DeleteOrder(string steelGrade)
        {
            var deletedOrder = orderService.DeleteOrder(steelGrade);
            if(deletedOrder == null)
                return NotFound();
            return Ok(deletedOrder);

        }

        [HttpPost("EditOrder")]
        public ActionResult<List<Order>> EditOrder(Order order)
        {
            var editedOrders = orderService.EditOrder(order);
            if(editedOrders == null)
                return NotFound();
            return Ok(editedOrders);
        }
        [HttpPost("AddOrder")]
        public ActionResult<Order> AddOrder(Order order)
        {
           return Ok(orderService.AddOrder(order));
        }

        [HttpPost("AddOrders")]
        public ActionResult<List<Order>> AddOrders(List<Order> orders)
        {
            return Ok(orderService.AddOrders(orders));
        }

    }
}
