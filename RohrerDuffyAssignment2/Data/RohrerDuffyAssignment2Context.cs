using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RohrerDuffyAssignment2.Models;

namespace RohrerDuffyAssignment2.Models
{
    public class RohrerDuffyAssignment2Context : DbContext
    {
        public RohrerDuffyAssignment2Context (DbContextOptions<RohrerDuffyAssignment2Context> options)
            : base(options)
        {
        }

        public DbSet<RohrerDuffyAssignment2.Models.Admin> Admin { get; set; }

        public DbSet<RohrerDuffyAssignment2.Models.Client> Client { get; set; }

        public DbSet<RohrerDuffyAssignment2.Models.Member> Member { get; set; }

        public DbSet<RohrerDuffyAssignment2.Models.Project> Project { get; set; }

        public DbSet<RohrerDuffyAssignment2.Models.User> User { get; set; }
    }
}
