using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ATS.WCF.Data.Models.Mapping
{
    public class PrivilegeMap : EntityTypeConfiguration<Privilege>
    {
        public PrivilegeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CreatedBy)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ModifiedBy)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Privilege");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.MenuId).HasColumnName("MenuId");
            this.Property(t => t.MenuItemId).HasColumnName("MenuItemId");
            this.Property(t => t.SubMenuId).HasColumnName("SubMenuId");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasOptional(t => t.LKRole)
                .WithMany(t => t.Privileges)
                .HasForeignKey(d => d.RoleId);
            this.HasRequired(t => t.LKStatu)
                .WithMany(t => t.Privileges)
                .HasForeignKey(d => d.Status);
            this.HasOptional(t => t.LKSubMenuItem)
                .WithMany(t => t.Privileges)
                .HasForeignKey(d => d.SubMenuId);
            this.HasOptional(t => t.Menu)
                .WithMany(t => t.Privileges)
                .HasForeignKey(d => d.MenuId);
            this.HasOptional(t => t.MenuItem)
                .WithMany(t => t.Privileges)
                .HasForeignKey(d => d.MenuItemId);

        }
    }
}
