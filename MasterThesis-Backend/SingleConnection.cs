namespace MasterThesis_Backend
{
    public class SingleConnection
    {
        public ConnectionType ConnectionType { get; set; }
        public Steel? ConnectedSteel { get; set; }
        public SingleConnection(ConnectionType connectionType, Steel connectedSteel)
        {
            this.ConnectionType = connectionType;
            this.ConnectedSteel = connectedSteel;
        }
    }
}
