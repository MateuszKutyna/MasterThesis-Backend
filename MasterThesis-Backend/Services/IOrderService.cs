namespace MasterThesis_Backend.Services
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        List<Order> AddOrder(Order order);
        List<Order> AddOrders(List<Order> orders);
        Order? DeleteOrder(string steelGrade);

        List<Order>? EditOrder(Order order);
        
    }
}
