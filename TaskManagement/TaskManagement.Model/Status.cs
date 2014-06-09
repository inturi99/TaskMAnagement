using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Model
{
  public  class Status
    {
        public Guid ID { get; set; }
        public string StatusName { get; set; }
        public string Description { get; set; }
       

        public RowStatus RowStatus { get; set; }
    }
}
