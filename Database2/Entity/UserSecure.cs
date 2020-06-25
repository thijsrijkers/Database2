using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Database2
{
    public class UserSecure
    {
        [Key]
        public int SecureID { get; set; }
        public int Inlog_Poging { get; set; }
        public bool Activated { get; set; }
        public int UserID { get; set; }
    }
}
