using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Database2
{
    public class Language
    {
        [Key]
        public int LanguageID { get; set; }
        public string Name { get; set; }
    }
}
