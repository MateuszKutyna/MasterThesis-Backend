namespace MasterThesis_Backend.Services
{
    public interface IScheduleOrdersService
    {
        Schedule ScheduleOrders();
        void ClearSchedule();
    }
}
