using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet <Country> countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"

                },
                new Country
                {
                    Id = 2,
                    Name = "Jordan",
                    ShortName = "JOR"

                },
                new Country
                {
                    Id = 3,
                    Name = "Palstine",
                    ShortName = "PAL"

                }

            );

            modelBuilder.Entity<Hotel>().HasData(
                
                new Hotel
                {
                    Id = 1,
                    Name = "7Dayes",
                    Adress = "Irbid",
                    CountryId = 2,
                    Rating = 4.2

                },
                new Hotel
                {
                    Id = 2,
                    Name = "Movmbic",
                    Adress = "Negril",
                    CountryId = 1,
                    Rating = 4.5

                },
                new Hotel
                {
                    Id = 3,
                    Name = "Talabay",
                    Adress = "Nablus",
                    CountryId = 3,
                    Rating = 3.5

                }



            );
        }

    }
}
