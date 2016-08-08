namespace PlaylistSystem.Services
{
    using Contracts;
    using System;
    using System.Linq;
    using Models;
    using Data.Repositories;

    public class PlaylistService : IPlaylistService
    {
        private IRepository<Playlist> playlists;

        public PlaylistService(IRepository<Playlist> playlists)
        {
            this.playlists = playlists;
        }

        public IQueryable<Playlist> GetAll()
        {
            return this.playlists.All();
        }

        public IQueryable<Playlist> GetTop(int count)
        {

            return this.playlists.All()
                .OrderByDescending(x => x.Ratings.Average(y=>y.Value))
                .Take(count);
        }

        public Playlist GetById(int id)
        {
            return this.playlists.GetById(id);
        }

        public Playlist Create(Playlist newArticle)
        {
            this.playlists.Add(newArticle);

            this.playlists.SaveChanges();

            return newArticle;
        }

        public Playlist UpdateById(int id, Playlist updatedArticle)
        {
            //var articleToUpdate = this.playlists.GetById(id);

            //articleToUpdate.CategoryId = updatedArticle.CategoryId;
            //articleToUpdate.Content = updatedArticle.Content;
            //articleToUpdate.Title = updatedArticle.Title;

            //this.playlists.SaveChanges();

            return updatedArticle;
        }

        public void DeleteById(int id)
        {
            this.playlists.Delete(id);
            this.playlists.SaveChanges();
        }
    }
}
