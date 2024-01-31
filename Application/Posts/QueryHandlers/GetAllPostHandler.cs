using Application.Abstraction;
using Application.Posts.Queries;
using Domain.Models;
using MediatR;

namespace Application.Posts.QueryHandlers
{
    public class GetAllPostHandler : IRequestHandler<GetAllPost, ICollection<Post>>
    {
        private readonly IPostRepository _postRepo;
        public GetAllPostHandler(IPostRepository postRepo)
        {
            _postRepo = postRepo;
        }
        public async Task<ICollection<Post>> Handle(GetAllPost request, CancellationToken cancellationToken)
        {
            return await _postRepo.GetAllPost();
        }
    }
}
