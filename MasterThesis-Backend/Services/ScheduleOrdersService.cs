using MasterThesis_Backend.Controllers;
using NRules;
using NRules.Fluent;
using NRules.Fluent.Dsl;
using ScheduleRules;

namespace MasterThesis_Backend.Services
{
    public class ScheduleOrdersService : IScheduleOrdersService
    {
       
        private static Schedule schedule = new Schedule();
        private static OrderService orderService = new OrderService();
        private static SteelConnectionsService steelConnectionsService = new SteelConnectionsService();

        public void ClearSchedule()
        {
            schedule.Orders = new List<Order>();
        }

        public Schedule ScheduleOrders()
        {
            
            var orders = orderService.GetAllOrders();
            var steelConnections = steelConnectionsService.GetSteelConnections();
            if (orders == null || orders.Count == 0)
                return schedule;

            schedule.Orders.Add(orders[0]);
            orders.RemoveAt(0);
            
            var repository = new RuleRepository();
            repository.Load(x => x.From(typeof(ScheduleOrders).Assembly));

            var factory = repository.Compile();

            var session = factory.CreateSession();

            session.InsertAll(orders);
            session.Insert(steelConnections);
            session.Insert(schedule);
            session.Fire();

            return schedule;
        }
    }
}
