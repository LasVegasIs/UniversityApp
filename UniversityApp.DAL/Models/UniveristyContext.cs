using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.DAL.Models
{
    public class UniveristyContext: DbContext
    {
        public UniveristyContext(DbContextOptions<UniveristyContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<TeacherReport> TeacherReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherReport>().HasNoKey();

            base.OnModelCreating(modelBuilder);
        }

    }
}
