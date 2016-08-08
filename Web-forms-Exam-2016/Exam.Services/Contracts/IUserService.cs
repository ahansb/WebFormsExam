using PlaylistSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistSystem.Services.Contracts
{
    public interface IUserService
    {
        IQueryable<User> GetAll();


        User GetById(string id);

        void Update(User user);


        void ChangeProfilePhotoUrl(string id, string url);

    }
}
