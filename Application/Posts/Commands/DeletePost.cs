using MediatR;

namespace Application.Posts.Commands
{
    public class DeletePost : IRequest<Unit>
    {
        public int PostId { get; set; }
    }
}
