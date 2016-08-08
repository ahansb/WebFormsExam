namespace PlaylistSystem
{
    using Models;
    using PlaylistSystem.Services.Contracts;
    using Ninject;
    using System;
    using System.Linq;

    public partial class Home : System.Web.UI.Page
    {
        public const int TopPlaylistssDisplayCountByLikes = 10;

        [Inject]
        public IPlaylistService PlaylistService { get; set; }

        [Inject]
        public ICategoryService CategoriesServices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public System.Collections.IEnumerable PlaylistRepeater_GetData()
        {
            return this.PlaylistService.GetTop(TopPlaylistssDisplayCountByLikes);
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Category> lvCategories_GetData()
        {
            return this.CategoriesServices.GetAll();
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Playlist> lvArticlesForCategory_GetData()
        {
            return null;
        }
    }
}