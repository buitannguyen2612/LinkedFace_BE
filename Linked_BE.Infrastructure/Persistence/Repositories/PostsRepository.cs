using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Linked_BE.Domain.Entities;
using Linked_BE.Domain.Interfaces;
using Linked_BE.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;


namespace Linked_BE.Infrastructure.Persistence.Repositories
{
    public class PostsRepository : IPostsRepository
    {
        private readonly AppDbContext _dbContext;
        public PostsRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Post>> GetAllPostAsync()
        {
            return await _dbContext.Posts.ToListAsync();
        }
    }
}