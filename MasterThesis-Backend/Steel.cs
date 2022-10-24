namespace MasterThesis_Backend
{

    public class Steel
    {
        public int Id { get; set; }
        public string SteelName { get; set; } = string.Empty;

        public string SteelGrade { get; set; } = string.Empty;

        public Steel(int id, string steelName, string steelGrade)
        {
            Id = id;
            SteelName = steelName;
            SteelGrade = steelGrade;
        }

    }

}
