using System;
using System.Collections.Generic;

#nullable disable

namespace multikino.Models
{
    public partial class Payment
    {
        public long Id { get; set; }
        public int Ammount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool Finalized { get; set; }
        public long? OrderId { get; set; }
        public string PaymentCardCardNumber { get; set; }

        public virtual Order Order { get; set; }
        public virtual PaymentCard PaymentCardCardNumberNavigation { get; set; }
    }
}
