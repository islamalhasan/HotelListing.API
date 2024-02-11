using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configuration
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(

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
