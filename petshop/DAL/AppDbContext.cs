using Miau.Areas.Admin.Model;
using Miau.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miau.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<ServiceBox> ServiceBoxes { get; set; }
        public DbSet<ServiceBox2> ServiceBoxes2 { get; set; }
        public DbSet<ServiceBox3> ServiceBoxes3 { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutImage> AboutImages { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Adopt> Adopts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<OurTeam> OurTeams { get; set; }
        public DbSet<OurTeamImage1> OurTeamImage1 { get; set; }
        public DbSet<OurTeamImage2> OurTeamImage2 { get; set; }
        public DbSet<OurTeamImage3> OurTeamImage3 { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Pat> Pats { get; set; }
        public DbSet<PostModel> Reservation { get; set; }



    }
}
