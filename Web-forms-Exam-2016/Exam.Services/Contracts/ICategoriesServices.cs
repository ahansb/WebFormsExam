namespace PlaylistSystem.Services.Contracts
{
    using PlaylistSystem.Models;
    using System.Linq;

    public interface ICategoryService
    {
        IQueryable<Category> GetAll();

        Category UpdateById(int id, string name);

        Category DeleteById(int id);

        Category Create(string name);
    }
}