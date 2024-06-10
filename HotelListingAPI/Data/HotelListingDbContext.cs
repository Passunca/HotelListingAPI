using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace HotelListingAPI.Data
{
    public class HotelListingDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JN"
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    Id = 3,
                    Name = "Cayman Island",
                    ShortName = "CI"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    Rating = 4.6,
                    CountryId = 1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Confort Suites",
                    Address = "George Town",
                    Rating = 4.3,
                    CountryId = 3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palldium",
                    Address = "Nassua",
                    Rating = 4,
                    CountryId = 2
                }
                );
        }


    }
}
