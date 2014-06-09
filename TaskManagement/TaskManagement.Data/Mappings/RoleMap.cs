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
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
       {
           HasKey(c => c.ID);
           Property(c => c.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           Property(it => it.RoleName).IsRequired().HasMaxLength(100);
           Property(it => it.Description).HasMaxLength(1000);
           Property(it => it.CreatedUserId).IsRequired();
           Property(it => it.UpdatedUserId).IsRequired();
           Property(it => it.CreateDateTime).IsRequired();
           Property(it => it.UpdateDateTime).IsRequired();
           Property(it => it.RowStatus);
         }
    }
}
