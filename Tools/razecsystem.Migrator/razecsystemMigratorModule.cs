using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using razecsystem.EntityFramework;

namespace razecsystem.Migrator
{
    [DependsOn(typeof(razecsystemDataModule))]
    public class razecsystemMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<razecsystemDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}