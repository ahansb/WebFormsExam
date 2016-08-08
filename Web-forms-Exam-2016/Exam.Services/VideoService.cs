namespace PlaylistSystem.Services
{
    using Data.Repositories;
    using Models;
    using PlaylistSystem.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class VideoService:IVideoService
    {
        private IRepository<Video> videos;
        public VideoService(IRepository<Video> videos)
        {
            this.videos = videos;
        }

        public IQueryable<Video> GetAll()
        {
            return this.videos.All();
        }
    }
}
