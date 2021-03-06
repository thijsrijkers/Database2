﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Database2
{
    public class WatchedMedia
    {
        [Key]
        public int WatchedMediaID { get; set; }
        public TimeSpan TimeStamp { get; set; }
        public int paused { get; set; }
        public int ProfileID { get; set; }
        public int MediaID { get; set; }
        public int UserID { get; set; }
    }
}
