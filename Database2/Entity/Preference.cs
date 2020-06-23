using System;
using System.Collections.Generic;
using System.Text;

namespace Database2
{
    public class Preference
    {
        public int PreferenceID { get; set; }
        public string Media { get; set; }
        public string Genre { get; set; }
        public string PEGI { get; set; }
        public int UserID { get; set; }
    }
}
