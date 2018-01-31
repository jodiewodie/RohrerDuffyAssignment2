using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RohrerDuffyAssignment2.Models
{
    public class Client : User
    {
        public string BusinessName { get; set; }
        public string Title { get; set; }
        public string AltContact { get; set; }
    }
}
