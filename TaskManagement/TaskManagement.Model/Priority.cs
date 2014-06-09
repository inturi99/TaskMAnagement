using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Model
{
   public class Priority
    {
        public Guid ID { get; set; }
        public string PriorityName { get; set; }
        public string Description { get; set; }
        public string PriorityColor { get; set; }
       
        public RowStatus RowStatus { get; set; }
    }
}
