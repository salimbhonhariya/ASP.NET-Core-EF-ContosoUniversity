using Microsoft.EntityFrameworkCore;
using SalimContosoUniversity.Models.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalimContosoUniversity.Data
{
    public class SchoolContext: DbContext
    {
            public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
            {
            }

            public DbSet<Course> Courses { get; set; }
            public DbSet<Enrollment> Enrollments { get; set; }
            public DbSet<Student> Students { get; set; }
        }
}
