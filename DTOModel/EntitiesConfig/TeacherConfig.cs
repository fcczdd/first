using DTOModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel.EntitiesConfig
{
    public class TeacherConfig:EntityTypeConfiguration<Teacher>
    {
        public TeacherConfig()
        {
            this.ToTable("T_Teachers");
            this.HasRequired(e => e.school).WithMany().HasForeignKey(e=>e.SchoolId).WillCascadeOnDelete(false);
            this.Property(e => e.Name).IsRequired().HasMaxLength(50);
            this.Property(e => e.passwordSalty).HasMaxLength(10);
            this.Property(e => e.password).IsRequired();
            this.Property(e => e.PhoneNum).IsRequired().HasMaxLength(20);
            this.Property(e => e.EmailAdress).HasMaxLength(50);
            this.Property(e => e.Age).IsRequired();
        }
    }
}
