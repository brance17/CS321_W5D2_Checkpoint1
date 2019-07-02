﻿using System;
using CS321_W5D2_BlogAPI.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CS321_W5D2_BlogAPI.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<ActivityType>().HasData(
            //    new ActivityType { Id = 1, Name = "Running", RecordType = RecordType.DurationAndDistance },
            //    new ActivityType { Id = 2, Name = "Weights", RecordType = RecordType.DurationOnly },
            //    new ActivityType { Id = 3, Name = "Walking", RecordType = RecordType.DurationAndDistance }
            //);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../CS321_W5D2_BlogAPI.Infrastructure/blog.db");
        }
    }
}
