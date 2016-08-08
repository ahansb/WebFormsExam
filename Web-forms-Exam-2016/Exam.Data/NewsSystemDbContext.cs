namespace PlaylistSystem.Data
{
    using System;
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using PlaylistSystem.Models;
    public class PlaylistSystemDbContext : IdentityDbContext<User>, IPlaylistSystemDbContext
    {
        public PlaylistSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Video> Videos { get; set; }

        public IDbSet<Playlist> Playlists { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Rating> Ratings { get; set; }

        public static PlaylistSystemDbContext Create()
        {
            return new PlaylistSystemDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Playlist>()
                .HasRequired(p => p.Category)
                .WithMany(x => x.Articles)
                .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }
    }
}
