using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Infra.Data.Configuration
{
	public class StatusAccountConfiguration : IEntityTypeConfiguration<StatusAccount>
	{
		public void Configure(EntityTypeBuilder<StatusAccount> builder)
		{
			builder.ToTable("STATUS_ACCOUNTS");

			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).HasColumnName("STATUS_ID").ValueGeneratedOnAdd();
			builder.Property(x => x.Name).HasColumnName("NAME").HasMaxLength(255).IsRequired();
			builder.Property(x => x.IsActive).HasColumnName("IS_ACTIVE").IsRequired();
			builder.Property(x => x.CreationDate).HasColumnName("STATUS_CREATING_DATE").ValueGeneratedOnAdd().IsRequired();
		}
	}
}
