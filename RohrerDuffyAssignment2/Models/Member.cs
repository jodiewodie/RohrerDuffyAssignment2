using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RohrerDuffyAssignment2.Models
{
    public class Member : User
    {
        public int BuffID { get; set; }
        public string AcademicStanding { get; set; }
    }
}
