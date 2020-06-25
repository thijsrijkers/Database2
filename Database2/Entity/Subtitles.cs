using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Database2
{
    public class Subtitles
    {
        [Key]
        public int SubtitleID { get; set; }
        public string SubtitleLink { get; set; }
        public int LanguageID { get; set; }
    }
}
