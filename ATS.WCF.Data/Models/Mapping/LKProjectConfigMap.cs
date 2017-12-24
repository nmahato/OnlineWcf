using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ATS.WCF.Data.Models.Mapping
{
    public class LKProjectConfigMap : EntityTypeConfiguration<LKProjectConfig>
    {
        public LKProjectConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("LKProjectConfig");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Value).HasColumnName("Value");
        }
    }
}
