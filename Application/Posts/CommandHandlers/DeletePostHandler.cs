using Application.Abstraction;
using Application.Posts.Commands;
using MediatR;

namespace Application.Posts.CommandHandlers
{
    public class DeletePostHandler : IRequestHandler<DeletePost, Unit>
    {
        private readonly IPostRepository _postRepo;
        public DeletePostHandler(IPostRepository postRepo)
        {
            _postRepo = postRepo;
        }

        public async Task<Unit> Handle(DeletePost request, CancellationToken cancellationToken)
        {
            await _postRepo.DeletePost(request.PostId);

            return Unit.Value;
        }
    }
}
