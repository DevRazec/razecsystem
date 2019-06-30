using System.Linq;
using razecsystem.EntityFramework;
using razecsystem.MultiTenancy;

namespace razecsystem.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly razecsystemDbContext _context;

        public DefaultTenantCreator(razecsystemDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
