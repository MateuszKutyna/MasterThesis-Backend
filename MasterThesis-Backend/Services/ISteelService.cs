namespace MasterThesis_Backend.Services
{
    public interface ISteelService
    {
        Task<List<Steel>> GetAllSteels();
        Task<Steel?> GetSteelById(int id);
        Task<List<Steel>> AddSteel(Steel steel);

    }
}
