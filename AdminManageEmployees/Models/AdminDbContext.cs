using Microsoft.EntityFrameworkCore;

namespace AdminManageEmployees.Models
{
    public class AdminDbContext : DbContext
    {
        public AdminDbContext(DbContextOptions<AdminDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.Email)
                .IsUnique();


        }
        //public class DateOfBirthRangeAttribute : RangeAttribute
        //{
        //    public DateOfBirthRangeAttribute()
        //        : base(typeof(DateTime),
        //               new DateTime(1975, 1, 1).ToShortDateString(),
        //               new DateTime(2001, 12, 31).ToShortDateString())
        //    { }
        //}

        public DbSet<Employee> Employees { get; set; }

        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<SystemCodeDetail> SystemCodeDetails { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<UserActivity> UserActivities { get; set; }
        public DbSet<SystemCode> SystemCodes { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
