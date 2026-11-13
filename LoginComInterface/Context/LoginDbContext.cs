using LoginComInterface.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginComInterface.Context
{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext()
        {
        }

        public LoginDbContext(DbContextOptions<LoginDbContext> options) : base(options)
        {
        }

        public DbSet<Login>? Logins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(DbConfig.ConnectionString);
            }
        }
    }
}
