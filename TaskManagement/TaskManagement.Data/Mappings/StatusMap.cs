using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Model;

namespace TaskManagement.Data.Mappings
{
    public class StatusMap : EntityTypeConfiguration<Status>
    {
        public StatusMap()
        {
            HasKey(c => c.ID);
            Property(c => c.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(it => it.StatusName).IsRequired().HasMaxLength(100);
            Property(it => it.Description).HasMaxLength(1000);
            Property(it => it.RowStatus);
           
        }
    }
}
