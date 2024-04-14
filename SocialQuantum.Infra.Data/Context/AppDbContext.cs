﻿using Microsoft.EntityFrameworkCore;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Infra.Data.Context
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        private DbSet<UserProfile> UserProfiles { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
		}
	}
}
