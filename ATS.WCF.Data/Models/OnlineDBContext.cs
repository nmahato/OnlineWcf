using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ATS.WCF.Data.Models.Mapping;

namespace ATS.WCF.Data.Models
{
    public partial class OnlineDBContext : DbContext
    {
        static OnlineDBContext()
        {
            Database.SetInitializer<OnlineDBContext>(null);
        }

        public OnlineDBContext()
            : base("Name=OnlineDBContext")
        {
        }

        public DbSet<LKProjectConfig> LKProjectConfigs { get; set; }
        public DbSet<LKRole> LKRoles { get; set; }
        public DbSet<LKState> LKStates { get; set; }
        public DbSet<LKStatu> LKStatus { get; set; }
        public DbSet<LKSubMenuItem> LKSubMenuItems { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Privilege> Privileges { get; set; }
       
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LKProjectConfigMap());
            modelBuilder.Configurations.Add(new LKRoleMap());
            modelBuilder.Configurations.Add(new LKStateMap());
            modelBuilder.Configurations.Add(new LKStatuMap());
            modelBuilder.Configurations.Add(new LKSubMenuItemMap());
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new MenuItemMap());
            modelBuilder.Configurations.Add(new PrivilegeMap());

            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
