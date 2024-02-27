using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityInsertTest
{
    public partial class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> entity)
        {
            entity.HasKey(t => t.Id);

            entity.Property(p => p.Id)
                .UseIdentityColumn();

            entity.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
