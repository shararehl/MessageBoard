using MessageBoard.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoard.Domain.Entities
{
    public class User:BaseEntity
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
    }
}
