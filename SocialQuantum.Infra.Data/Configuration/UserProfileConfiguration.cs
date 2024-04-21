using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Infra.Data.Configuration
{
	public class UserProfileConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.ToTable("USERS");

			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).HasColumnName("USER_ID").ValueGeneratedOnAdd();
			builder.Property(x => x.UserName).HasColumnName("USERNAME").HasMaxLength(255).IsRequired();
			builder.Property(x => x.Email).HasColumnName("EMAIL").HasMaxLength(255).IsRequired();
			builder.Property(x => x.Password).HasColumnName("PASSWORD").HasMaxLength(255).IsRequired();
			builder.Property(x => x.Name).HasColumnName("NAME").HasMaxLength(255).IsRequired();
			builder.Property(x => x.Photo).HasColumnName("USER_PHOTO");
			builder.Property(x => x.Biography).HasColumnName("BIOGRAPHY").HasMaxLength(255);
			builder.Property(x => x.Location).HasColumnName("LOCATION").HasMaxLength(255).IsRequired();
			builder.Property(x => x.StatusAccountId).HasColumnName("STATUS_ACCOUNT_ID").IsRequired();
			builder.Property(x => x.CreationDate).HasColumnName("USER_CREATING_DATE");

			builder.HasOne<StatusAccount>(x => x.StatusAccount)
				.WithMany(y => y.UserProfiles)
				.HasForeignKey(j => j.StatusAccountId);
		}

	}
}
