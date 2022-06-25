using System;
using System.Collections.Generic;

#nullable disable

namespace multikino.Models
{
    public partial class Room
    {
        public Room()
        {
            RoomSeanceSets = new HashSet<RoomSeanceSet>();
        }

        public long Id { get; set; }
        public int Capacity { get; set; }

        public virtual ICollection<RoomSeanceSet> RoomSeanceSets { get; set; }
    }
}
