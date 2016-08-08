namespace PlaylistSystem.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    public class Video
    {
        public int Id { get; set; }

        public string URL { get; set; }

        public virtual int PlaylistId { get; set; }

        [ForeignKey("PlaylistId")]
        public virtual Playlist Playlist { get; set; }


    }
}
