using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Database2
{
    public class Preference
    {
        [Key]
        public int PreferenceID { get; set; }
        public string Media { get; set; }
        public string Genre { get; set; }
        public string PEGI { get; set; }
        public int UserID { get; set; }
    }
}
