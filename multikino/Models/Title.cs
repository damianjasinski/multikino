using System;
using System.Collections.Generic;

#nullable disable

namespace multikino.Models
{
    public partial class Title
    {
        public Title()
        {
            Seances = new HashSet<Seance>();
            TitlesCategories = new HashSet<TitlesCategory>();
        }

        public long Id { get; set; }
        public string ImUrl { get; set; }
        public int Length { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Seance> Seances { get; set; }
        public virtual ICollection<TitlesCategory> TitlesCategories { get; set; }
    }
}
