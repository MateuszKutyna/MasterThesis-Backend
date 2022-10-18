namespace MasterThesis_Backend
{
    public class SteelConnections
    {
        public Steel? Steel { get; set; }

        public List<SingleConnection>? ListOfConnections { get; set; }
        public SteelConnections(Steel steel, List<SingleConnection> listOfConnections)
        {
            this.Steel = steel;
            this.ListOfConnections = listOfConnections;
        }
    }
}
