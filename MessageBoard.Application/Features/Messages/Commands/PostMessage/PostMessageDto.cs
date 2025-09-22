namespace MessageBoard.Application.Features.Messages.Commands.PostMessage
{
    public class PostMessageDto
    {
        public string Username { get; set; }
        public string ProjectName { get; set; }
        public string Content { get; set; }
    }
}