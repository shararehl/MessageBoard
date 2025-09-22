using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoard.Application.Features.Messages.Commands.PostMessage
{
    public class PostMessageCommand : IRequest<Guid>
    {
        public string Content { get; set; }
        public string Username { get; set; }
        public string ProjectName { get; set; }

    }
}
