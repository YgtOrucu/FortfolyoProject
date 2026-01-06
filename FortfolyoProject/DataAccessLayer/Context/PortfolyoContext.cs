using FortfolyoProject.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace FortfolyoProject.DataAccessLayer.Context
{
    public class PortfolyoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YIGITORUCU\\MY_UDEMY_KURSU;Initial Catalog=DB_UdemyFortfolyoProject;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
