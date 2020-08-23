using Microsoft.EntityFrameworkCore;
using dk.A1.S1.UserMng.UserMngModel.Models;

namespace dk.A1.S1.UserMng.UserMngModel.Datas
{
    public class UserMngContext : DbContext
    {
        public UserMngContext(DbContextOptions<UserMngContext> options) : base(options)
        {
        }

        public DbSet<UserMst> UserMst { get; set; }

        public DbSet<UserProfile> UserProfile { get; set; }

        public DbSet<UserRoleSetting> UserRoleSetting { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configs.UserMstConfig());
            modelBuilder.ApplyConfiguration(new Configs.UserProfileConfig());
            modelBuilder.ApplyConfiguration(new Configs.UserRoleSettingConfig());
        }
}
}