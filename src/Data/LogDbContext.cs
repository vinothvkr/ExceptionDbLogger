using System;
using ExceptionDbLogger.Models;
using Microsoft.EntityFrameworkCore;

namespace ExceptionDbLogger.Data 
{
    public class LogDbContext : DbContext
    {
        public LogDbContext(DbContextOptions<LogDbContext> options)
            :base(options)
        {
        }

        public DbSet<LogEntry> LogEntries { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}