using DSS_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSS_MVC.Repository
{
    public class DBContext:DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DBContext(DbContextOptions<DBContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }
        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));
            var userId = _httpContextAccessor.HttpContext.User.Identity.Name;
            var currentUsername = !string.IsNullOrEmpty(userId)
                ? userId
                : "Anonymous";

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedDate = DateTime.UtcNow;
                    ((BaseEntity)entity.Entity).CreatedBy = currentUsername;
                }
                ((BaseEntity)entity.Entity).ModifiedDate = DateTime.UtcNow;
                ((BaseEntity)entity.Entity).ModifiedBy = currentUsername;
            }
        }
    }
}
