using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoreManagementSystem.Models
{
    public class Major
    {
        public string MajorID { get; set; }
        public string Name { get; set; }
        public string Academy { get; set; }
        public string AcademyId { get; set; }
        public string MinimumCredits { get; set; }
    }
}