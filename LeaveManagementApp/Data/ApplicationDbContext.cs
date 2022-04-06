using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        /*By setting up DbSet, it creates a table modelled off the respective
        class_name which is set inside DbSet<T> (When Migrated), Here:
        - Dbset<LeaveType> creates table "LeaveTypes" based on "LeaveType.cs"
        - Dbset<LeaveAllocation> creates table "LeaveAllocations" based on "LeaveAllocation.cs"
         */
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    }
}
