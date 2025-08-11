using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Linked_BE.Domain.Entities;
using Linked_BE.Domain.Interfaces;
using Linked_BE.Infrastructure.EFCore;

namespace Linked_BE.Infrastructure.Persistence.Repositories
{
    public class ImageRepository : IImageRepository
    {
        // Assuming you have a DbContext injected here
        private readonly AppDbContext _dbContext;

        public ImageRepository(AppDbContext context)
        {
            _dbContext = context;
        }

        public async Task CreateImageAsync(List<Images> images)
        {
            if (images == null || !images.Any())
                throw new ArgumentException("Image list cannot be null or empty at CreateImageAsync");

            await _dbContext.Images.AddRangeAsync(images);
            await _dbContext.SaveChangesAsync();
        }
    }
}