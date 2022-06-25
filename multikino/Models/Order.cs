using System;
using System.Collections.Generic;

#nullable disable

namespace multikino.Models
{
    public partial class Order
    {
        public Order()
        {
            Payments = new HashSet<Payment>();
        }

        public long Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? SeanceId { get; set; }
        public int? SeatId { get; set; }
        public long? UsersId { get; set; }

        public virtual Seance Seance { get; set; }
        public virtual Seat Seat { get; set; }
        public virtual User Users { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
