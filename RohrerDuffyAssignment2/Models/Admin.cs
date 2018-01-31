using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RohrerDuffyAssignment2.Models
{
    public class Admin : User
    {
        public string ClubTitle { get; set; }
        public string AcademicStanding { get; set; }
    }
}
