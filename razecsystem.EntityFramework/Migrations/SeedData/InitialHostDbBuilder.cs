using razecsystem.EntityFramework;
using EntityFramework.DynamicFilters;

namespace razecsystem.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly razecsystemDbContext _context;

        public InitialHostDbBuilder(razecsystemDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
