using System.Text.Json.Serialization;

namespace MasterThesis_Backend
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ConnectionType
    {
        A, B, X
    }

    public class Order
    {
        public string Name { get; set; }
        public string SteelGrade { get; set; }

        public int Tonnage { get; set; }
        public ConnectionType? ConnectionType { get; set; } = null;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
