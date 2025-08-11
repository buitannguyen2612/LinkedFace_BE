using Linked_BE.Application.DTOs;
using Linked_BE.Application.Interfaces;
using Linked_BE.Domain.Entities;
using Linked_BE.Domain.Interfaces;

namespace Linked_BE.Application.Services.Posts
{

    public class CreateNewPostUseCase
    {
        private readonly IPostsRepository _postRepository;
        private readonly ITransactionManager _transactionManager;
        private readonly IImageRepository _imageRepository;
        public CreateNewPostUseCase(IPostsRepository postRepository, ITransactionManager transactionManager, IImageRepository imageRepository)
        {
            _postRepository = postRepository;
            _transactionManager = transactionManager;
            _imageRepository = imageRepository;
        }

        public async Task CreatePostAsync(PostCreateDTO postRequest)
        {
            if (postRequest == null)
            {
                throw new ArgumentNullException(nameof(postRequest), "CreatePostAsync requires a non-null post.");
            }

            await _transactionManager.BeginTransactionAsync();

            try
            {
                var post = new Post
                {
                    ID = Guid.NewGuid(),
                    UserId = postRequest.UserId,
                    Title = postRequest.Title,
                    Descriptions = postRequest.Descriptions,
                    CreateAt = DateTime.UtcNow
                };
                await _postRepository.CreatePostAsync(post);

                if (postRequest.Image != null)
                {
                    var images = postRequest.Image.Select(image => new Images
                    {
                        Id = Guid.NewGuid(),
                        UserId = postRequest.UserId,
                        PostId = post.ID,
                        ImageKey = image.ImageKey,
                    }).ToList();

                    await _imageRepository.CreateImageAsync(images);
                }

                await _transactionManager.CommitTransactionAsync();
            }
            catch
            {
                await _transactionManager.RollbackTransactionAsync();
                throw;
            }

        }
    }
}