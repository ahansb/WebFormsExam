using PlaylistSystem.Data.Repositories;
using PlaylistSystem.Models;
using PlaylistSystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistSystem.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> users;


        public UserService(IRepository<User> users)
        {
            this.users = users;
        }

        public IQueryable<User> GetAll()
        {
            return this.users.All();
        }

        public User GetById(string id)
        {
            return this.users.All().FirstOrDefault(x => x.Id == id);
        }

        public void Update(User user)
        {
            this.users.Update(user);
            this.users.SaveChanges();
        }



        public void ChangeProfilePhotoUrl(string id, string url)
        {
            var user = this.GetById(id);

            user.ProfilePhotoUrl = url;

            this.users.Update(user);

            this.users.SaveChanges();
        }


    }
}
