using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Linked_BE.Domain.Entities;

namespace Linked_BE.Infrastructure.EFCore
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Friendships> Friendships { get; set; }
        public DbSet<Saved> Saved { get; set; }
        public DbSet<ReportType> ReportType { get; set; }
        public DbSet<Reports> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Fluent API configuration if needed
        }

    }
}