using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Model
{
   public class IssueType
   {
       public Guid ID { get; set; }
       public string IssueTypeName { get; set; }
       public RowStatus RowStatus { get; set; }
    }
}
