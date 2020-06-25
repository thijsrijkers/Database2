using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Database2
{
    public class InviteList
    {
        [Key]
        public int InviteID { get; set; }
        public int OtherUserID { get; set; }
        public string InviteDate { get; set; }
        public int UserID { get; set; }
    }
}
