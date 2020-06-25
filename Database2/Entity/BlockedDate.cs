using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Database2
{
    public class BlockedDate
    {
        [Key]
        public int BlockedDateID { get; set; }
        public DateTime BlockedDateTime { get; set; }
        public bool Blocked { get; set; }
        public DateTime BlockedTime { get; set; }
        public int SecureID { get; set; }
    }
}
