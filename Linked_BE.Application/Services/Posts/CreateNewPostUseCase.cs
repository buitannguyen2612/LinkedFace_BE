using Linked_BE.Application.DTOs;
using Linked_BE.Domain.Entities;
using Linked_BE.Domain.Interfaces;

namespace Linked_BE.Application.Services.Posts
{

    public class CreateNewPostUseCase
    {
        private readonly IPostsRepository _postRepository;
        public CreateNewPostUseCase(IPostsRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task CreatePostAsync(PostCreateDTO postRequest)
        {
            if (postRequest == null)
            {
                throw new ArgumentNullException(nameof(postRequest), "CreatePostAsync requires a non-null post.");
            }

            var post = new Post
            {
                ID = Guid.NewGuid(),
                UserId = postRequest.UserId,
                Title = postRequest.Title,
                Descriptions = postRequest.Descriptions,
                CreateAt = DateTime.UtcNow
            };
            await _postRepository.CreatePostAsync(post);

            var images = postRequest.Image?.Select(image => new Images
            {
                Id = Guid.NewGuid(),
                UserId = postRequest.UserId,
                PostId = post.ID,
                ImageKey = image.ImageKey,
            }).ToList();
        }
    }
}