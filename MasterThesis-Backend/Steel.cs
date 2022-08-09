namespace MasterThesis_Backend
{

    public enum CastingType
    {
        Dozatorowe, Zatyczkowe
    }

    public class Steel
    {
        public int Id { get; set; }
        public string SteelGrade { get; set; } = string.Empty;

        public string Instruction { get; set; } = string.Empty;

        public CastingType CastingType { get; set; } = CastingType.Zatyczkowe; //ZATYCZKOWE JAKO DEFAULT

        public int maxAmountOfCasting { get; set; } // MAX ILOŚĆ WYTOPÓW
        public int waitTime { get; set; }   //CZAS WYPRZEDZENIA
    }

}
