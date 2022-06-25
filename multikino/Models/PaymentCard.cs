using System;
using System.Collections.Generic;

#nullable disable

namespace multikino.Models
{
    public partial class PaymentCard
    {
        public PaymentCard()
        {
            Payments = new HashSet<Payment>();
        }

        public string Id { get; set; }
        public string Cvv { get; set; }
        public DateTime ExpDate { get; set; }
        public long UsersId { get; set; }

        public virtual User Users { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
