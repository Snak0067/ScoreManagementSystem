using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoreManagementSystem.Models
{
    public class AcademyHealth
    {
        public string Academy { get; set; }
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public int Declared { get; set; }
        public int NoDeclared { get; set; }
        public int TotalNumber { get; set; }
        public string DeclareDegrees { get; set; }
    }
}