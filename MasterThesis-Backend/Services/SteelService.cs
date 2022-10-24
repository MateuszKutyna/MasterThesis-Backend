using MasterThesis_Backend.Data;

namespace MasterThesis_Backend.Services
{
    public class SteelService : ISteelService
    {
        private readonly DataContext _dataContext;

        public SteelService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task<List<Steel>> AddSteel(Steel steel)
        {
            _dataContext.Steels.Add(steel);
            await _dataContext.SaveChangesAsync();

            return await _dataContext.Steels.ToListAsync();
        }

        public async Task<Steel?> DeleteSteel(int id)
        {
           var steel = await _dataContext.Steels.FindAsync(id);
            if (steel == null) return null;
            _dataContext.Steels.Remove(steel);
            await _dataContext.SaveChangesAsync();
            return steel;
        }

        public async Task<List<Steel>> GetAllSteels()
        {
            return await _dataContext.Steels.ToListAsync();
        }

        public async Task<Steel?> GetSteelById(int id)
        {
            return await _dataContext.Steels.FindAsync(id);
        }
    }
}
