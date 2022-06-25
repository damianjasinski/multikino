using System;
using System.Collections.Generic;

#nullable disable

namespace multikino.Models
{
    public partial class TitlesCategory
    {
        public long TitlesCategoryId { get; set; }  
        public long TitlesId { get; set; }
        public long CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Title Titles { get; set; }
    }
}
