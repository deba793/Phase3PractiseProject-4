using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Phase3PractiseProject_4.Models;

namespace Phase3PractiseProject_4.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext (DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Phase3PractiseProject_4.Models.Student> Student { get; set; } = default!;
    }
}
