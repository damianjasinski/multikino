using System;
using System.Collections.Generic;

#nullable disable

namespace multikino.Models
{
    public partial class RoomSeanceSet
    {
        public long RoomSeanceSetId { get; set; }
        public long RoomId { get; set; }
        public long SeanceSetId { get; set; }

        public virtual Room Room { get; set; }
        public virtual Seance SeanceSet { get; set; }
    }
}
