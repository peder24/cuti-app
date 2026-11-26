using backend_cuti_app.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_cuti_app.Data
{
    public class CutiDbContext : DbContext
    {
        public CutiDbContext(DbContextOptions<CutiDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveBalance> LeaveBalances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<LeaveRequest>()
                .Property(lr => lr.Status)
                .HasConversion<string>();
            
            // relasi 1 to many
            modelBuilder.Entity<LeaveRequest>()
                .HasOne(lr => lr.User)
                .WithMany(u => u.LeaveRequests)
                .HasForeignKey(lr => lr.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            
            // relasi 1 to 1
            modelBuilder.Entity<LeaveBalance>()
                .HasOne(lb => lb.User)
                .WithOne()
                .HasForeignKey<LeaveBalance>(lb => lb.UserId);
        }   
    }
}
