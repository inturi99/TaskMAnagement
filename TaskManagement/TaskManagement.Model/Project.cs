using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Model
{
   public class Project
    {
      
        public Guid ID { get; set; }
        
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string Key { get; set; }
        public Guid UserID { get; set; }
        public virtual User User { get; set; }

        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public Guid CreatedUserId { get; set; }
        public Guid UpdatedUserId { get; set; }
        public RowStatus RowStatus { get; set; }
    }
}
