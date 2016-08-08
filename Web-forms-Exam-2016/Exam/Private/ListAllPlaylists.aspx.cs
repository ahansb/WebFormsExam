using Ninject;
using PlaylistSystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq.Dynamic;

namespace PlaylistSystem.Private
{
    public partial class ListAllPlaylists : System.Web.UI.Page
    {

        public const string SortDirection = "Descending";

        [Inject]
        public IPlaylistService PlaylistService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<PlaylistSystem.Models.Playlist> gvPlaylist_GetData()
        {
            return this.PlaylistService.GetAll();
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<PlaylistSystem.Models.Playlist> lvPlaylists_GetData([QueryString]string orderBy, [QueryString]string sortDirection)
        {
            var result = this.PlaylistService.GetAll();

            
            // TODO: validate orderBy parameter
            if (sortDirection == null)
            {
                sortDirection = SortDirection;
            }

            if (orderBy == "Rating" && sortDirection == "Ascending")
            {
               return result.OrderBy(p => p.Ratings.Average(r => r.Value));

            }
            if(orderBy == "Rating" && sortDirection == "Descending")
            {
                return result.OrderByDescending(p => p.Ratings.Average(r => r.Value));
            }
            else
            {
                result = orderBy != null ? result.OrderBy(orderBy + " " + sortDirection) : result.OrderBy(x => x.DateCreated);
            }

            return result;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void lvPlaylists_UpdateItem(int id)
        {
            PlaylistSystem.Models.Playlist item = null;
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes here, e.g. MyDataLayer.SaveChanges();

            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void lvPlaylists_DeleteItem(int id)
        {

        }

        public void lvPlaylists_InsertItem()
        {
            var item = new PlaylistSystem.Models.Playlist();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes here

            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {


        }
    }
}