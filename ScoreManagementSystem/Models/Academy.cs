using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScoreManagementSystem.Models
{
    public class Academy
    {
        [Key]
        public string ID { get; set; }
        [Display(Name = "学院名称")]
        public string Name { get; set; }
        [Display(Name = "学院人数")]
        public int Num { get; set; }

    }
}