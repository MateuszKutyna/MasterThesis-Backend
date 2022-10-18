namespace MasterThesis_Backend
{

    public class Steel
    {
        public int Id { get; set; }
        public string SteelName { get; set; } = string.Empty;

        public string SteelGrade { get; set; } = string.Empty;

        public Steel(string steelName, string steelGrade)
        {
            SteelName = steelName;
            SteelGrade = steelGrade;
        }

    }

}
