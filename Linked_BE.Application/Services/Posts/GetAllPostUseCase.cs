using Linked_BE.Application.DTOs;
using Linked_BE.Domain.Interfaces;

namespace Linked_BE.Application.Services
{
    public class GetAllPostUseCase
    {
        private readonly IPostsRepository _postRepository;

        public GetAllPostUseCase(IPostsRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<List<PostDTO>> ExecuteAsync(int take = 10)
        {
            var posts = await _postRepository.GetAllPostAsync(take);

            return posts.Select(p => new PostDTO
            {
                Id = p.ID,
                Title = p.Title,
                Content = p.Descriptions,
                User = new UserDTO
                {
                    Id = p.User.Id,
                    Auth0UserId = p.User.Auth0UserId,
                    MiddleName = p.User.MiddleName,
                    LastName = p.User.LastName,
                    PhoneNumber = p.User.PhoneNumber,
                    AvatarKey = p.User.AvatarKey
                }
            }).ToList();
        }
    }
}