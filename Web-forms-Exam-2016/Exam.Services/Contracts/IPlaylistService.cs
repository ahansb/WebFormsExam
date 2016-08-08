namespace PlaylistSystem.Services.Contracts
{
    using Models;
    using System.Linq;

    public interface IPlaylistService
    {
        IQueryable<Playlist> GetTop(int count);

        IQueryable<Playlist> GetAll();

        Playlist UpdateById(int id, Playlist updatedArticle);

        void DeleteById(int id);

        Playlist GetById(int id);

        Playlist Create(Playlist newArticle);
    }
}
