namespace PlaylistSystem.App_Start
{
    using PlaylistSystem.Data;
    using System.Data.Entity;
    using PlaylistSystem.Data.Migrations;

    public class DbConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PlaylistSystemDbContext, Configuration>());

            PlaylistSystemDbContext.Create().Database.Initialize(true);
        }
    }
}