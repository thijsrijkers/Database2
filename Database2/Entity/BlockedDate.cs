using System;
using System.Collections.Generic;
using System.Text;

namespace Database2
{
    public class BlockedDate
    {
        public int BlockedDateID { get; set; }
        public DateTime BlockedDateTime { get; set; }
        public bool Blocked { get; set; }
        public DateTime BlockedTime { get; set; }
        public int SecureID { get; set; }
    }
}
