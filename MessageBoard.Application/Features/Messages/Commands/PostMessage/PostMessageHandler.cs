using MediatR;
using MessageBoard.Application.Contracts;
using MessageBoard.Application.Exceptions;
using MessageBoard.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoard.Application.Features.Messages.Commands.PostMessage
{
    public class PostMessageHandler : IRequestHandler<PostMessageCommand,Guid>
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Project> _projectRepository;
        private readonly IRepository<Message> _messageRepository;

        public PostMessageHandler(IRepository<User> userRepository, IRepository<Project> projectRepository, IRepository<Message> messageRepository)
        {
            _userRepository = userRepository;
            _projectRepository = projectRepository;
            _messageRepository = messageRepository;
        }

        public async Task<Guid> Handle(PostMessageCommand request, CancellationToken cancellationToken)
        {
            var validator = new PostMessageCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            var user = (await _userRepository.GetAllAsync()).FirstOrDefault(u => u.Username == request.Username);
            var project = (await _projectRepository.GetAllAsync()).FirstOrDefault(p => p.Name == request.ProjectName);
            var message = new Message
            {
                Id = Guid.NewGuid(),
                Content = request.Content,
                UserId = user.Id,
                ProjectId = project.Id,                
                CreatedById = user.Id,
                CreatedByUsername = user.Username,
                CreatedDate = DateTime.UtcNow,
                User = user,
                Project = project
            };
            var result = await _messageRepository.AddAsync(message);
            return result.Id;
        }
    }
}
