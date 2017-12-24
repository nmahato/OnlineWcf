using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ATS.WCF.Data.Models.Mapping
{
    public class LKSubMenuItemMap : EntityTypeConfiguration<LKSubMenuItem>
    {
        public LKSubMenuItemMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CreatedBy)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ModifiedBy)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("LKSubMenuItem");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ActionName).HasColumnName("ActionName");
            this.Property(t => t.ControllerName).HasColumnName("ControllerName");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.MenuId).HasColumnName("MenuId");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasRequired(t => t.LKStatu)
                .WithMany(t => t.LKSubMenuItems)
                .HasForeignKey(d => d.Status);

        }
    }
}
