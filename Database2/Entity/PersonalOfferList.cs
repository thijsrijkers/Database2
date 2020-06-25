using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Database2
{
    public class PersonalOfferList
    {
        [Key]
        public int PersonalOfferListID { get; set; }
        public int ProfileID { get; set; }
        public int WatchedMediaID { get; set; }
        public int UserID { get; set; }
    }
}
