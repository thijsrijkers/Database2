using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Database2
{
    public class Profile
    {
        [Key]
        public int ProfileID { get; set; }
        public string ProfileName { get; set; }
        public int Age { get; set; }
        public string ProfilePicture { get; set; }
        public string Language { get; set; }
        public int UserID { get; set; }
    }
}
