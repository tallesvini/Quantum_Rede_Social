using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Infra.Data.Configuration
{
	public class VisibilityConfiguration : IEntityTypeConfiguration<Visibility>
	{
		public void Configure(EntityTypeBuilder<Visibility> builder)
		{
			builder.ToTable("VISIBILITY");

			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).HasColumnName("VISIBILITY_ID").ValueGeneratedOnAdd();
			builder.Property(x => x.Name).IsRequired().HasColumnName("NAME").HasMaxLength(255);
			builder.Property(x => x.IsActive).IsRequired().HasColumnName("IS_ACTIVE");
			builder.Property(x => x.CreationDate).HasColumnName("VISIBILITY_CREATE_DATE");
		}
	}
}
