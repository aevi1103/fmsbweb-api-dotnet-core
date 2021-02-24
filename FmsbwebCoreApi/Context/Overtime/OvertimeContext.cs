using System;
using FmsbwebCoreApi.Entity.Overtime;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FmsbwebCoreApi.Context.Overtime
{
    public partial class OvertimeContext : DbContext
    {
        public OvertimeContext()
        {
        }

        public OvertimeContext(DbContextOptions<OvertimeContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Entity.Overtime.Overtime> Overtime { get; set; }
        public virtual DbSet<Entity.Overtime.Type> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
