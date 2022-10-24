using MasterThesis_Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace MasterThesis_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController: ControllerBase
    {
        private readonly IScheduleOrdersService scheduleOrders;

        public ScheduleController(IScheduleOrdersService scheduleOrders)
        {
            this.scheduleOrders = scheduleOrders;
        }

        [HttpGet("ScheduleOrders")]
        public ActionResult<Schedule> ScheduleOrders()
        {
            return Ok(scheduleOrders.ScheduleOrders());
        }

        [HttpPost("ClearSchedule")]
        public ActionResult<Schedule> ClearSchedule()
        {
            scheduleOrders.ClearSchedule();
            return Ok("Schedule cleared");
        }

        [HttpGet("GetSchedule")]
        public ActionResult<Schedule> GetSchedule()
        {
            return Ok(scheduleOrders.GetSchedule());
        }

    }
}
