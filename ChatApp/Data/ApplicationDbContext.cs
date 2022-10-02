using ChatApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Message>()
                .HasOne<User>(u => u.user).WithMany(d => d.Messages).HasForeignKey(d => d.userid);
            builder.Entity<UserConnection>()
            .HasKey(o => new { o.Username, o.ConnectionId });
        }
        public DbSet<Message>Messages{ get; set; }
        public DbSet<UserConnection>userConnections{ get; set; }
    }
}
