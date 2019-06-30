using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using razecsystem.Authorization.Roles;
using razecsystem.Authorization.Users;
using razecsystem.MultiTenancy;

namespace razecsystem.EntityFramework
{
    public class razecsystemDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public razecsystemDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in razecsystemDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of razecsystemDbContext since ABP automatically handles it.
         */
        public razecsystemDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public razecsystemDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public razecsystemDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
