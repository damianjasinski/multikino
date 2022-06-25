using System;
using System.Collections.Generic;

#nullable disable

namespace multikino.Models
{
    public partial class Seance
    {
        public Seance()
        {
            Orders = new HashSet<Order>();
        }

        public long Id { get; set; }
        public int AdvertisementTime { get; set; }
        public long? RoomId { get; set; }
        public DateTime SeanceDate { get; set; }
        public long? TitlesId { get; set; }

        public virtual Title Titles { get; set; }
        public virtual RoomSeanceSet RoomSeanceSet { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
