using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Database2
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; } 
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
