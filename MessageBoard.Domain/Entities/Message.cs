using MessageBoard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoard.Domain.Entities
{
    public class Message:BaseEntity
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
