namespace PlaylistSystem
{
    using Services.Contracts;
    using Ninject;
    using System;
    using System.Web.ModelBinding;
    using Models;
    using System.Linq;
    public partial class ViewPlaylistDetails : System.Web.UI.Page
    {
        [Inject]
        public IPlaylistService PlaylistService { get; set; }

        [Inject]
        public IVideoService VideoService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public PlaylistSystem.Models.Playlist fvPlaylist_GetItem([QueryString]string id)
        {
            // TODO: validation and error message
            return this.PlaylistService.GetById(int.Parse(id));
        }

        public IQueryable<Video> VideoRepeater_GetData1(int id)
        {
            return this.VideoService.GetAll().Where(v=>v.PlaylistId== id);
        }
    }
}