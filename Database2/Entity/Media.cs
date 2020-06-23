using System;
using System.Collections.Generic;
using System.Text;

namespace Database2
{
    public class Media
    {
        public int MediaID { get; set; }
        public string Genre { get; set; }
        public string PEGI { get; set; }
        public string MediaType { get; set; }
        public string MediaTitle { get; set; }
        public int MediaEpisode { get; set; }
        public string Quality { get; set; }
        public int SubtitleID { get; set; }
    }
}
