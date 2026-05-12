using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Platform_for_freelancing.Models
{
    public class FreelanceAPIContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Freelancer> Freelancers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Bid> Bids { get; set; }

        public FreelanceAPIContext(DbContextOptions<FreelanceAPIContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bid>()
                .HasOne(b => b.Freelancer)
                .WithMany(f => f.Bids)
                .HasForeignKey(b => b.FreelancerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}