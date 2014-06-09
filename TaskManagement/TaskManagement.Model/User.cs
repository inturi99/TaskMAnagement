using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Model
{
  public  class User
    {
       
        public Guid ID { get; set; }
       
        public string UserName { get; set; }
      
        public String Password { get; set; }
        
        public string ConformPasword { get; set; }
      
        public string FullName { get; set; }
        
        public Gender Gender { get; set; }
        
        public string EmailId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public Guid CreatedUserId { get; set; }
        public Guid UpdatedUserId { get; set; }
        public RowStatus RowStatus { get; set; }

        
    }
}
