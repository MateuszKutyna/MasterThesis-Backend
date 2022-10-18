namespace MasterThesis_Backend
{
    public class Schedule
    {
        public List<Order> Orders { get; set; }
        public Schedule()
        {
            Orders = new List<Order>();
        }

        public void PrintAllSteelFromSchedule()
        {
            foreach (Order steel in Orders)
            {
                Console.WriteLine($"Name: {steel.Name}, Grade: {steel.SteelGrade}, Tonnage: {steel.Tonnage}, Connection: {steel.ConnectionType}");
            }
        }
    }
}
