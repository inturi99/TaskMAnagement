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
    public class PriorityMap : EntityTypeConfiguration<Priority>
    {
        public PriorityMap(){  
           HasKey(c => c.ID);
           Property(c => c.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           Property(it => it.PriorityName).IsRequired().HasMaxLength(100);
           Property(it => it.Description).HasMaxLength(1000);
           Property(it => it.PriorityColor).IsRequired().HasMaxLength(10);
           Property(it => it.RowStatus);
        }
    }
}
