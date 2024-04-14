using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Infra.Data.Configuration
{
	public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
	{
		public void Configure(EntityTypeBuilder<UserProfile> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.UserName).HasMaxLength(255).IsRequired();
			builder.Property(x => x.Photo);
			builder.Property(x => x.Biography).HasMaxLength(255);
			builder.Property(x => x.IsActive).IsRequired();
			builder.Property(x => x.CreationDate).ValueGeneratedOnAdd();
			builder.Property(x => x.LastEditDate);
		}
	}
}
