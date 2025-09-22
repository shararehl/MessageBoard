using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoard.Domain.Common
{
    public class BaseEntity
    {
        public string CreatedByUsername { get; set; }
        public Guid CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? LastModifiedByUsername { get; set; }
        public Guid LastModifiedById { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
