﻿using Application.Abstraction;
using Application.Posts.Commands;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.CommandHandlers
{
    public class UpdatePostHandler : IRequestHandler<UpdatePost, Post>
    {
        private readonly IPostRepository _postRepo;
        public UpdatePostHandler(IPostRepository postRepo)
        {
            _postRepo = postRepo;
        }
        public async Task<Post> Handle(UpdatePost request, CancellationToken cancellationToken)
        {
            var post = await _postRepo.UpdatePost(request.PostContent, request.PostId);
            return post;
        }
    }
}
