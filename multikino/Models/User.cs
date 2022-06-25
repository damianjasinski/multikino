using System;
using System.Collections.Generic;

#nullable disable

namespace multikino.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            PaymentCards = new HashSet<PaymentCard>();
        }

        public long Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "USER";
        public string UserFirstname { get; set; }
        public string UserSurname { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PaymentCard> PaymentCards { get; set; }
    }
}
