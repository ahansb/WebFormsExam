namespace PlaylistSystem.Data.Migrations
{
    using PlaylistSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Remoting.Contexts;
    public class SeedData
    {
        public static Random Rand = new Random();

        public List<User> Users;

        public List<Category> Categories;

        public List<Playlist> Playlists;

        public List<Video> Videos;

        public List<Rating> Ratings;
        

        public SeedData(List<User>users)
        {

            this.Users = users;
            var one =Rand.Next(1,4);
            var two  =Rand.Next(1,4);
            var three =Rand.Next(1,4);
            var four =Rand.Next(1,4);
            var five =Rand.Next(1,4);
            var six =Rand.Next(1,4);
            var seven =Rand.Next(1,4);
            var eight =Rand.Next(1,4);
            var nine =Rand.Next(1,4);
            var ten =Rand.Next(1,4);

            this.Categories = new List<Category>();
            Categories.Add(new Category() { Name = "Category1" });
            Categories.Add(new Category() { Name = "Category2" });
            Categories.Add(new Category() { Name = "Category3" });
            Categories.Add(new Category() { Name = "Category4" });
            Categories.Add(new Category() { Name = "Category5" });
            Categories.Add(new Category() { Name = "Category6" });
            Categories.Add(new Category() { Name = "Category7" });
            Categories.Add(new Category() { Name = "Category8" });
            Categories.Add(new Category() { Name = "Category9" });
            Categories.Add(new Category() { Name = "Category10" });
            Categories.Add(new Category() { Name = "Category11" });
            Categories.Add(new Category() { Name = "Category12" });
            Categories.Add(new Category() { Name = "Category13" });
            Categories.Add(new Category() { Name = "Category14" });
            Categories.Add(new Category() { Name = "Category15" });
            Categories.Add(new Category() { Name = "Category16" });
            Categories.Add(new Category() { Name = "Category17" });
            Categories.Add(new Category() { Name = "Category18" });
            Categories.Add(new Category() { Name = "Category19" });
            Categories.Add(new Category() { Name = "Category20" });
            Categories.Add(new Category() { Name = "Category21" });
            Categories.Add(new Category() { Name = "Category22" });
            Categories.Add(new Category() { Name = "Category23" });
            Categories.Add(new Category() { Name = "Category24" });
            Categories.Add(new Category() { Name = "Category25" });
            Categories.Add(new Category() { Name = "Category26" });
            Categories.Add(new Category() { Name = "Category27" });
            Categories.Add(new Category() { Name = "Category28" });
            Categories.Add(new Category() { Name = "Category29" });
            Categories.Add(new Category() { Name = "Category30" });

            this.Playlists = new List<Playlist>();
            Playlists.Add(new Playlist() { Title = "Playlist1", Description = "PlaylistDescription1", Category = Categories[Rand.Next(1, 29)], CreatorId = Users[one].Id, Creator = Users[one], DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)) });
            Playlists.Add(new Playlist() { Title = "Playlist2", Description = "PlaylistDescription2", Category = Categories[Rand.Next(1, 29)], CreatorId = Users[two].Id, Creator = Users[two], DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)) });
            Playlists.Add(new Playlist() { Title = "Playlist3", Description = "PlaylistDescription3", Category = Categories[Rand.Next(1, 29)], CreatorId = Users[three].Id, Creator = Users[three], DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)) });
            Playlists.Add(new Playlist() { Title = "Playlist4", Description = "PlaylistDescription4", Category = Categories[Rand.Next(1, 29)], CreatorId = Users[four].Id, Creator = Users[four], DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)) });
            Playlists.Add(new Playlist() { Title = "Playlist5", Description = "PlaylistDescription5", Category = Categories[Rand.Next(1, 29)], CreatorId = Users[five].Id, Creator = Users[five], DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)) });
            Playlists.Add(new Playlist() { Title = "Playlist6", Description = "PlaylistDescription6", Category = Categories[Rand.Next(1, 29)], CreatorId = Users[six].Id, Creator = Users[six], DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)) });
            Playlists.Add(new Playlist() { Title = "Playlist7", Description = "PlaylistDescription7", Category = Categories[Rand.Next(1, 29)], CreatorId = Users[seven].Id, Creator = Users[seven], DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)) });
            Playlists.Add(new Playlist() { Title = "Playlist8", Description = "PlaylistDescription8", Category = Categories[Rand.Next(1, 29)], CreatorId = Users[eight].Id, Creator = Users[eight], DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)) });
            Playlists.Add(new Playlist() { Title = "Playlist9", Description = "PlaylistDescription9", Category = Categories[Rand.Next(1, 29)], CreatorId = Users[nine].Id, Creator = Users[nine], DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)) });
            Playlists.Add(new Playlist() { Title = "Playlist10", Description = "PlaylistDescription10", Category = Categories[Rand.Next(1, 29)], CreatorId = Users[ten].Id, Creator = Users[ten], DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)) });


            this.Videos = new List<Video>();
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });
            Videos.Add(new Video() { URL = "https://www.youtube.com/watch?v=PWa7xDXjv_Y&index=38&list=PL4a7-RmE1GdP0mGtzg1tmmaUdrIsBArCv", Playlist=Playlists[Rand.Next(1,9)] });

            this.Ratings = new List<Rating>();
            Ratings.Add(new Rating() { Playlist = Playlists[Rand.Next(1, 9)], User = Users[Rand.Next(1, 4)], Value=Rand.Next(1,5) });
            Ratings.Add(new Rating() { Playlist = Playlists[Rand.Next(1, 9)], User = Users[Rand.Next(1, 4)], Value=Rand.Next(1,5) });
            Ratings.Add(new Rating() { Playlist = Playlists[Rand.Next(1, 9)], User = Users[Rand.Next(1, 4)], Value=Rand.Next(1,5) });
            Ratings.Add(new Rating() { Playlist = Playlists[Rand.Next(1, 9)], User = Users[Rand.Next(1, 4)], Value=Rand.Next(1,5) });
            Ratings.Add(new Rating() { Playlist = Playlists[Rand.Next(1, 9)], User = Users[Rand.Next(1, 4)], Value=Rand.Next(1,5) });
                                                                      
            
        }
    }
}