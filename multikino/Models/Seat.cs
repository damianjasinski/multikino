using System;
using System.Collections.Generic;

#nullable disable

namespace multikino.Models
{
    public partial class Seat
    {
        public Seat()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
