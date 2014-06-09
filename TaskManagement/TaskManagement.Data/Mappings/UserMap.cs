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
    public class UserMap : EntityTypeConfiguration<User>
    {
       public UserMap()
       {
           HasKey(c => c.ID);
           Property(c => c.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           Property(it => it.UserName).IsRequired().HasMaxLength(100);
           Property(it => it.Password).IsRequired().HasMaxLength(30);
           Property(it => it.ConformPasword).IsRequired().HasMaxLength(30);
           Property(it => it.EmailId).IsRequired().HasMaxLength(50);
           Property(it => it.FullName).IsRequired().HasMaxLength(100);
           Property(it => it.Gender).IsRequired();
           Property(it => it.CreatedUserId).IsRequired();
           Property(it => it.UpdatedUserId).IsRequired();
           Property(it => it.CreateDateTime).IsRequired();
           Property(it => it.UpdateDateTime).IsRequired();
           Property(it => it.RowStatus);
          


          
       }
    }
}
