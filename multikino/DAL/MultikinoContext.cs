
using multikino.Models;
using Microsoft.EntityFrameworkCore;
namespace multikino.DAL
{
    public class MultikinoContext : DbContext
    {

        public MultikinoContext(DbContextOptions<MultikinoContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { Id = 1, UserSurname = "Carson", UserFirstname = "Alexander", Password = "123" });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Seance> Seances { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<PaymentCard> PaymentCards { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }



    }
}
