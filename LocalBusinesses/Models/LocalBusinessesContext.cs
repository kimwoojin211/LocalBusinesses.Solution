using Microsoft.EntityFrameworkCore;

namespace LocalBusinesses.Models
{
  public class LocalBusinessesContext : DbContext
  {
    public LocalBusinessesContext(DbContextOptions<LocalBusinessesContext> options)
        : base(options)
    {
    }

    public DbSet<Business> Businesses { get; set; }
  protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Business>()
            .HasData(
                new Business     {
                  BusinessId= 1,
                  Name= "Mom's Spaghetti",
                  Category= "Restaurant",
                  OwnedBy= "Mom Mom",
                  Address= "1 Mom St.",
                  PhoneNumber= "180000081",
                  HoursOpen= "11:00",
                  HoursClose= "23:59"
                },
                new Business     {
                  BusinessId= 2,
                  Name= "Momma's",
                  Category= "Shop",
                  OwnedBy= "Moms",
                  Address= "2 Mom St.",
                  PhoneNumber= "180000082",
                  HoursOpen= "08:00",
                  HoursClose= "22:00"
                },
                new Business     {
                  BusinessId= 3,
                  Name= "Mom's",
                  Category= "Restaurant",
                  OwnedBy= "Mommy",
                  Address= "3 Mom St.",
                  PhoneNumber= "180000083",
                  HoursOpen= "08:00",
                  HoursClose= "17:00"
                },
                new Business     {
                  BusinessId= 4,
                  Name= "Mother",
                  Category= "Shop",
                  OwnedBy= "Mother Dearest",
                  Address= "4 Mom St.",
                  PhoneNumber= "180000084",
                  HoursOpen= "06:00",
                  HoursClose= "20:00"
                }, 
                new Business
                {
                  BusinessId = 5,
                  Name = "Mama's",
                  Category = "Restaurant",
                  OwnedBy = "Cooking Mama",
                  Address = "5 Mom St.",
                  PhoneNumber = "180000085",
                  HoursOpen = "05:00",
                  HoursClose = "23:00"
                },
                new Business     {
                  BusinessId= 6,
                  Name= "Madre",
                  Category= "Restaurant",
                  OwnedBy= "Mother Español",
                  Address= "6 Mom St.",
                  PhoneNumber= "180000086",
                  HoursOpen= "11:00",
                  HoursClose= "23:59"
                },
                new Business     {
                  BusinessId= 7,
                  Name= "Mère",
                  Category= "Restaurant",
                  OwnedBy= "Les Français",
                  Address= "7 Mom St.",
                  PhoneNumber= "180000087",
                  HoursOpen= "17:00",
                  HoursClose= "23:59"
                },
                new Business     {
                  BusinessId= 8,
                  Name= "For Moms",
                  Category= "Shop",
                  OwnedBy= "Everyone's Mom",
                  Address= "8 Mom St.",
                  PhoneNumber= "18888888888",
                  HoursOpen= "08:00",
                  HoursClose= "20:00"
                },
                new Business     {
                  BusinessId= 9,
                  Name= "Four Moms",
                  Category= "Shop",
                  OwnedBy= "Mom Mom",
                  Address= "9 Mom St.",
                  PhoneNumber= "180000089",
                  HoursOpen= "08:00",
                  HoursClose= "18:00"
                },
                new Business     {
                  BusinessId= 10,
                  Name= "FortMoms",
                  Category= "Shop",
                  OwnedBy= "Flossem McDawsom",
                  Address= "10 Mom St.",
                  PhoneNumber= "180000810",
                  HoursOpen= "00:00",
                  HoursClose= "23:59"
                }
            );
      }
  }
}