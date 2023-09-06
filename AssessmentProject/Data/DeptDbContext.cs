using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssessmentProject.Models;

namespace AssessmentProject.Data
{
    public class DeptDbContext : DbContext
    {
        public DeptDbContext (DbContextOptions<DeptDbContext> options)
            : base(options)
        {
        }

        public DbSet<AssessmentProject.Models.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<AssessmentProject.Models.EmpProfile>? EmpProfile { get; set; }
    }
}
