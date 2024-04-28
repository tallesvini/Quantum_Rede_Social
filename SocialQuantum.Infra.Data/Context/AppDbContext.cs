using Microsoft.EntityFrameworkCore;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Infra.Data.Context
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        private DbSet<User> UserProfiles { get; set; }
        private DbSet<StatusAccount> StatusAccounts { get; set; }
        private DbSet<Visibility> Visibilities { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
		}
	}
}
