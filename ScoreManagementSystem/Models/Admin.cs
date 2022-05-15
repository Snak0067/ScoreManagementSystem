using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScoreManagementSystem.Models
{
    public class Admin
    {
        [Key]
        public string Id { get; set; }
        [Display(Name = "密码")]
        public string Password { get; set; }
        [Display(Name = "身份")]
        public string Role { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }

    }
}