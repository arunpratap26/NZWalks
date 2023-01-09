using NZWalks.API.Models.Domains;

namespace NZWalks.API.Repositories
{
    public interface IRegionRepository
    {
       Task<IEnumerable<Region>> GetAllAsync();
    }
}
