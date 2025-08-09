using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Linked_BE.Domain.Entities;
using Linked_BE.Domain.Interfaces;

namespace Linked_BE.Application.Services.Posts
{
    public class UpdatePostUseCase
    {
        private readonly IPostsRepository _postRepository;

        public UpdatePostUseCase(IPostsRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task UpdatePostAsync(Post post)
        {
            if (post == null)
            {
                throw new ArgumentNullException(nameof(post), "UpdatePostAsync requires a non-null post.");
            }

            await _postRepository.UpdatePostAsync(post);
        }
    }
}