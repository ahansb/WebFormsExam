namespace PlaylistSystem.Services.Contracts
{
    using PlaylistSystem.Models;
    using System.Linq;
    public interface IVideoService
    {
        IQueryable<Video> GetAll();
    }
}
