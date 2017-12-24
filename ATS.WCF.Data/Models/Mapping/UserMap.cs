using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ATS.WCF.Data.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.UserId)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Password)
                .HasMaxLength(50);

            this.Property(t => t.FirstName)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.MiddleName)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.LastName)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Address1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.Address2)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.City)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.CreatedBy)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.ModifiedBy)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.StateId).HasColumnName("StateId");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.CountyId).HasColumnName("CountyId");
            this.Property(t => t.ZipCpde).HasColumnName("ZipCpde");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasOptional(t => t.LKRole)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.RoleId);
            this.HasRequired(t => t.LKState)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.StateId);
            this.HasRequired(t => t.LKStatu)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.Status);

        }
    }
}
