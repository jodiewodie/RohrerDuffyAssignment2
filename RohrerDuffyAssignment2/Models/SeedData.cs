using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RohrerDuffyAssignment2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RohrerDuffyAssignment2Context(
                serviceProvider.GetRequiredService<DbContextOptions<RohrerDuffyAssignment2Context>>()))
            {
                // Look for any movies.
                if (context.Admin.Any())
                {
                    return;   // DB has been seeded
                }

                context.Admin.AddRange(
                     new Admin
                     {
                         ID = 1,
                         FirstName = "Jodie",
                         LastName = "Rohrer",
                         Project = "Coding Club",
                         Email = "jodie.rohrer@gmail.com",
                         Phone = "8063408084",
                         ClubTitle = "Officer",
                         AcademicStanding = "Senior"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}

