using System;
using System.Collections.Generic;

#nullable disable

namespace multikino.Models
{
    public partial class Category
    {
        public Category()
        {
            TitlesCategories = new HashSet<TitlesCategory>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TitlesCategory> TitlesCategories { get; set; }
    }
}
