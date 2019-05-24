using DTOModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel.EntitiesConfig
{
   public  class SchoolConfig :EntityTypeConfiguration<School>
    {
        public SchoolConfig()
        {
            this.ToTable("T_Schools");
            this.Property(e => e.Name).IsRequired().HasMaxLength(50);
        }
    }
}
