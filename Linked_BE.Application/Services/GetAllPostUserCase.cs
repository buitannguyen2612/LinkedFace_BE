using Linked_BE.Application.DTOs;
using Linked_BE.Domain.Interfaces;

namespace Linked_BE.Application.Services
{
    public class GetAllPostUserCase
    {
        private readonly IPostsRepository _postRepository;

        public GetAllPostUserCase(IPostsRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<List<PostDTO>> ExecuteAsync()
        {
            var posts = await _postRepository.GetAllPostAsync();

            return posts.Select(p => new PostDTO
            {
                Id = p.ID,
                Title = p.Title,
                Content = p.Descriptions
            }).ToList();
        }
    }
}