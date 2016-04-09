using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCManager.Core.Entities
{
    public abstract class BaseEntity
    {
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int UserId { get; set; }
        public string IP { get; set; }
    }
}
