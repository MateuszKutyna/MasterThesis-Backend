namespace MasterThesis_Backend.Services
{
    public class OrderService : IOrderService
    {
        private static List<Order> orders = new List<Order> { };

        
        public List<Order> AddOrder(Order order)
        {
            orders.Add(order);
            return orders;
        }

        public Order? DeleteOrder(string steelGrade)
        {
            var order = orders.SingleOrDefault(o=> o.SteelGrade.Equals(steelGrade));
            if(order == null)
                return null;

            orders.Remove(order);

            return order;

        }

        public List<Order>? EditOrder(Order order)
        {
            var index = orders.FindIndex(o=> o.SteelGrade == order.SteelGrade);
            if (index == -1)
                return null;
            orders[index] = order;
            return orders;
        }

        public List<Order> GetAllOrders()
        {
            return orders;
        }

        public List<Order> AddOrders(List<Order> ordersList)
        {
            var combined = orders.Concat(ordersList).ToList();
            orders = combined;
            return orders;
        }
    }
}
