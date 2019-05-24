using DTOModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel.EntitiesConfig
{
   public class StudentConfig:EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            this.ToTable("T_Students");
            this.Property(e => e.Age).IsRequired();
            this.Property(e => e.Name).IsRequired().HasMaxLength(50);
            this.Property(e => e.Gender).IsRequired();
            this.Property(e => e.PhoneNum).IsRequired().HasMaxLength(20);
            this.Property(e => e.EmailAdress).IsRequired().HasMaxLength(50);
            this.Property(e => e.passwordSalty).HasMaxLength(10);
            this.Property(e => e.EnrollmentYear).IsRequired();
            this.HasRequired(e => e.School).WithMany().HasForeignKey(e=>e.schoolId).WillCascadeOnDelete(false);
            this.HasMany(e => e.Teachers).WithMany(t => t.students).Map(m => m.ToTable("T_StudentTeacherRalations").MapLeftKey("StudentId").MapRightKey("teacherId"));
        }
    }
}
