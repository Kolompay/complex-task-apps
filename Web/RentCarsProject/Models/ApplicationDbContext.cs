using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentCarsProject.Data;

namespace RentCarsProject.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        public virtual DbSet<bonussystem> bonussystem { get; set; }
        public virtual DbSet<car> car { get; set; }
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<fine> fine { get; set; }
        public virtual DbSet<locationcar> locationcar { get; set; }
        public virtual DbSet<rate> rate { get; set; }
        public virtual DbSet<rentcar> rentcar { get; set; }
        public virtual DbSet<returncar> returncar { get; set; }
    }
}
